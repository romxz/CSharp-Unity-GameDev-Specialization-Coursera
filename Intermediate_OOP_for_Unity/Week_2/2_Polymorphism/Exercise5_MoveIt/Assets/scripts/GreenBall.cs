using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball {
    // Start is called before the first frame update
    protected override void Start() {
        impulseVector.x = 0;
        impulseVector.y = 1;
        base.Start();
    }

    protected override void PrintMessage() {
        print("greenball");
    }
}
