using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        // 1. Set up your variables (Change these to your actual birth month and day!)
        int daysInMyMonth = 31; 
        int myActualBirthday = 6; 

        // 2. Start the loop to count from 1 up to the total days in the month
        for (int day = 1; day <= daysInMyMonth; day++)
        {
            // 3. Check if the current day matches your birthday
            if (day == myActualBirthday)
            {
                // If it's a match, print the special message
                Debug.Log("Its my birthday!");
            }
            else
            {
                // Otherwise, just print the normal day number
                Debug.Log(day);
            }
        }
    }
}
