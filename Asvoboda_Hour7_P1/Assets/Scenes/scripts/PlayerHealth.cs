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

        // 11 & 12. Subtract damage and log again
        health -= poisonDamage;
        Debug.Log(health);

        // 13. Copy and paste until health reaches 0
        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health); 

        // 14. Final death message
        Debug.Log("Player has been unalived!");
    }
}