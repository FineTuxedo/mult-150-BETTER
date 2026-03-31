using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // 1. The three versions of the method (Method Overloading)
    // Put these OUTSIDE of Start and Update
    
    // Version 1: No parameters
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 10;
    }

    // Version 2: One parameter (damage)
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    // Version 3: Two parameters (damage and armor)
    int TakeDamageFromFireball(int damage, int armor)
    {
        int playerHealth = 100;
        return playerHealth - (damage - armor);
    }

    void Start()
    {
        // 2. Calling the first version
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        // 3. Calling the second version
        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        // 4. Calling the third version
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }
}