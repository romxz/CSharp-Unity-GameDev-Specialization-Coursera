using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// French fries
/// </summary>
public class FrenchFries : IntEventInvoker {
    [SerializeField]
    GameObject prefabExplosion;

    // saved for efficiency
    Rigidbody2D rb2d;

    /// <summary>
    /// Initializes object. We don't use Start for this because
    /// we want to set up the points added event when we
    /// create the object in the french fries pool
    /// </summary>
    public void Initialize() {
        rb2d = GetComponent<Rigidbody2D>();

        // add as invoker for PointsAddedEvent
        unityEvents.Add(EventName.PointsAddedEvent, new PointsAddedEvent());
        EventManager.AddInvoker(EventName.PointsAddedEvent, this);
    }

    /// <summary>
    /// Starts the french fries moving
    /// </summary>
    public void StartMoving() {
        // apply impulse force to get projectile moving
        rb2d.AddForce(
            new Vector2(0, ConfigurationUtils.FrenchFriesImpulseForce),
            ForceMode2D.Impulse);
    }

    /// <summary>
    /// Stops the french fries
    /// </summary>
    public void StopMoving() {
        rb2d.velocity = Vector2.zero;
    }

    /// <summary>
    /// Called when the french fries become invisible
    /// </summary>
    void OnBecameInvisible() {
        // return to the pool
        FrenchFriesPool.ReturnFrenchFries(gameObject);
    }

    /// <summary>
    /// Processes trigger collisions with other game objects
    /// </summary>
    /// <param name="other">information about the other collider</param>
    void OnTriggerEnter2D(Collider2D other) {
        // if colliding with teddy bear, add score, destroy teddy bear,
        // and return self to pool
        if (other.gameObject.CompareTag("TeddyBear")) {
            unityEvents[EventName.PointsAddedEvent].Invoke(ConfigurationUtils.BearPoints);
            Instantiate(prefabExplosion,
                other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Instantiate(prefabExplosion,
                transform.position, Quaternion.identity);
            FrenchFriesPool.ReturnFrenchFries(gameObject);
        } else if (other.gameObject.CompareTag("TeddyBearProjectile")) {
            // if colliding with teddy bear projectile, destroy projectile and 
            // return self to pool
            Instantiate(prefabExplosion,
                other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Instantiate(prefabExplosion,
                transform.position, Quaternion.identity);
            FrenchFriesPool.ReturnFrenchFries(gameObject);
        }
    }
}
