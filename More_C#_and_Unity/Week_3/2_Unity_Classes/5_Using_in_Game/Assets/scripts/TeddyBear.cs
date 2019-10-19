using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    
    int health = 100;

    /// <summary>
    /// Take damage on collision with fish
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject collisionObject = coll.gameObject;
        if (collisionObject.CompareTag("Fish"))
        {
            // take damage and destroy fish
            Fish script = collisionObject.GetComponent<Fish>();
            health -= script.Damage;
            script.Destroy();

            // check for death
            if (health <= 0)
            {
                Instantiate(prefabExplosion, transform.position, 
                    Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
