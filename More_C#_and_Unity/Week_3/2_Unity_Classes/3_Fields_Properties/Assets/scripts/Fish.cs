using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {
    [SerializeField]
    GameObject prefabExplosion;

    int damage = 100;

    #region Properties

    /// <summary>
    /// Gets the damage inflicted by the fish
    /// </summary>
    public int Damage {
        get { return damage; }
    }

    #endregion

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
