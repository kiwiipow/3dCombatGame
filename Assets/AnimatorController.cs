using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    private float velocity;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
       
        velocity = 0f;

     
        if (Input.GetKey(KeyCode.W))
        {
            velocity = 0.5f;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl))
        {
            velocity = 1.5f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity = 2.5f;
        }
        animator.SetFloat("Blend", velocity);
        animator.SetBool("IsJump", Input.GetKey(KeyCode.Space));
        animator.SetBool("IsDuck", Input.GetKey(KeyCode.LeftShift));
    }
}
