using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour
{
    #region Fields

    [SerializeField]
    GameObject prefabExplosion;

    // damage support
    int damage = 100;

    #endregion

    #region Properties

    /// <summary>
    /// Gets how much damage the fish causes
    /// </summary>
    /// <value>damage</value>
    public int Damage
    {
        get { return damage; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Fires the fish
    /// </summary>
    void OnMouseUpAsButton()
    {
        // apply impulse force to fire the fish
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0, 5000),
            ForceMode2D.Impulse);
    }

    /// <summary>
    /// Destroy when leave game
    /// </summary>
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Destroys the fish
    /// </summary>
    public void Destroy()
    {
        Instantiate(prefabExplosion, transform.position, 
            Quaternion.identity);
        Destroy(gameObject);
    }

    #endregion
}
