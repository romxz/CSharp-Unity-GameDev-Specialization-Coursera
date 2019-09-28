using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const int MaxScore = 100;
        int score = 77;
        float percent = (float)score / MaxScore;
        print("Percent: " + (100*percent) + "%");
    }

}
