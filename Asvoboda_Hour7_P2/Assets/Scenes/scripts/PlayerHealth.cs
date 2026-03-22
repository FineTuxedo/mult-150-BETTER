using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        // 8. Create 2 float variables
        float health;
        float poisonDamage;

        // 9. Assign values
        health = 1004f;
        poisonDamage = 125.5f;

        // 10. Log the starting health
        Debug.Log(health);

        // --- NEW LOOP CODE ---
        // Step 3: Loop runs as long as health is greater than 0
        while (health > 0) 
        {
            // Step 4: Subtract damage and log inside the loop
            health -= poisonDamage;
            Debug.Log(health);
        }

        // Steps 5 & 6: Check if dead and print the final message
        if (health <= 0)
        {
            Debug.Log("Player has been unalived!");
        }
    }
}