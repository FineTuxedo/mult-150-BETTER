using UnityEngine;

public class LampAnimationController : MonoBehaviour
{
    // This variable will hold our Animator component
    private Animator animator;

    void Start()
    {
        // Tell Unity to look at the Lamp object and grab its Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 1. If W is pressed, trigger the color change animation
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("W");
        }
        
        // 2. If A is pressed, trigger the scaling size animation
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("A");
        }
        
        // 3. If S is pressed, trigger the spinning rotation animation
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("S");
        }
        
        // 4. If D is pressed, trigger the hover position animation
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("D");
        }
    }
}