using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addition : MonoBehaviour
{
    void Start()
    {
        // 1. Create 4 int variables
        int a;
        int b;
        int c;
        int sum;

        // 2. Assign values
        a = 2;
        b = 4;
        c = 8;

        // 3. Add a, b, and c together and assign the result to sum
        sum = a + b + c;

        // 4. Use the increment operator to increase the value of sum by 1
        sum++;

        // 5. Log the value of sum to the console
        Debug.Log(sum);
    }
}
