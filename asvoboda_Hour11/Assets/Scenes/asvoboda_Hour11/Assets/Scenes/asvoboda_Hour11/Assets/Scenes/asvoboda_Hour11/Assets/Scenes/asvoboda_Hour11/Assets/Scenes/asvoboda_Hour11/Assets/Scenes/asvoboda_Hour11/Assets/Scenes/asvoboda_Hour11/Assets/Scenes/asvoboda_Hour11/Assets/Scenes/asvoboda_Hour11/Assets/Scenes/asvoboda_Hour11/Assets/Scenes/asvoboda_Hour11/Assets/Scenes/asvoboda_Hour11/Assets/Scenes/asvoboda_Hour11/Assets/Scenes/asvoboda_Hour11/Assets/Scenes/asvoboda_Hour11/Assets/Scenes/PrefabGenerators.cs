using UnityEngine;

public class PrefabGenerators : MonoBehaviour
{
    public GameObject prefab;
    
    // Add a spacing variable so you can easily adjust how far apart they spawn in the Inspector
    public float spacing = 3f; 

    void Start()
    {
        // This loop runs 10 times to spawn 10 lamps
        for (int i = 0; i < 10; i++)
        {
            // Calculate a new position for each lamp. 
            // It takes the spawn point's position and adds distance along the X axis based on 'i'.
            Vector3 spawnPosition = new Vector3(transform.position.x + (i * spacing), transform.position.y, transform.position.z);
            
            // Spawn the lamp at the new calculated position
            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
