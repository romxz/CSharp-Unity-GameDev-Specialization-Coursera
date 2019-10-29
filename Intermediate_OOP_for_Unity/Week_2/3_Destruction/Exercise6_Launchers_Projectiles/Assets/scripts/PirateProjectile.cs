using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateProjectile : Projectile {
    // Start is called before the first frame update
    override protected void Start() {
        impulseForce.x = 3f;
        base.Start();
    }

}
