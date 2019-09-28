using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Converts from F to C and back
/// </summary>
public class ConvertTemperature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Problem 1
        int tempF, tempC, tempFnew;
        // Note: Can refactor, but instructions say to do it this way
        tempF = 0;
        print("Original temp in F: " + tempF);
        tempC = (int) (5 * (float) (tempF-32) / 9);
        print("Converted temp in C: " + tempC);
        tempFnew = (int) (tempC * 9 / 5 + 32);
        print("Converted temp back into F: " + tempFnew);
        print("---");
        tempF = 32;
        print("Original temp in F: " + tempF);
        tempC = (int)(5 * (float)(tempF - 32) / 9);
        print("Converted temp in C: " + tempC);
        tempFnew = (int)(tempC * 9 / 5 + 32);
        print("Converted temp back into F: " + tempFnew);
        print("---");
        tempF = 212;
        print("Original temp in F: " + tempF);
        tempC = (int)(5 * (float)(tempF - 32) / 9);
        print("Converted temp in C: " + tempC);
        tempFnew = (int)(tempC * 9 / 5 + 32);
        print("Converted temp back into F: " + tempFnew);
        print("===");

        // Problem 2
        float tempF2, tempC2, tempFnew2;
        tempF2 = 0;
        print("Original temp in F: " + tempF2);
        tempC2 = 5 * (tempF2 - 32) / 9;
        print("Converted temp in C: " + tempC2);
        tempFnew2 = tempC2 * 9 / 5 + 32;
        print("Converted temp back into F: " + tempFnew2);
        print("===");

        // Problem 3
        double tempF3, tempC3, tempFnew3;
        tempF3 = 0;
        print("Original temp in F: " + tempF3);
        tempC3 = 5 * (tempF3 - 32) / 9;
        print("Converted temp in C: " + tempC3);
        tempFnew3 = tempC3 * 9 / 5 + 32;
        print("Converted temp back into F: " + tempFnew3);
        print("===");
    }
}
