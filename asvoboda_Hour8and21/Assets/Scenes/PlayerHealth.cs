using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Step 1: Create the variable above Start()
    int healthpoints = 3992;

    void Start()
    {
        // Step 2.1 & 2.2: Use a potion and log it
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); // Should print 4392

        // Step 2.3 & 2.4: Spam potions! 
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); // Should print 4792

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); // Should print 5192

        // Step 2.5: Paste until it matches Zell's ending health (5592)
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); // Should print 5592
    }

    void Update()
    {
        // You can leave this empty for this assignment
    }

    // Step 1 (Bottom part): Create the UsePotion method below Update()
    int UsePotion(int health)
    {
        return health + 400;
    }
}