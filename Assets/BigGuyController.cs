using UnityEngine;

public class BigGuyController : MonoBehaviour
{
    private Animator animator;
    private float speed;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        speed = 0f;

        if (Input.GetKey(KeyCode.I))
        {
            speed = 0.5f;
        }
        if (Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.RightControl))
        {
            speed = 1.5f;
        }
        if (Input.GetKey(KeyCode.J))
        {
             speed = 2.5f;
        }
        animator.SetFloat("Blend", speed);
        animator.SetBool("IsJump", Input.GetKey(KeyCode.Backspace));
        animator.SetBool("IsDuck", Input.GetKey(KeyCode.RightShift));
        animator.SetBool("IsHeavyAttack", Input.GetKey(KeyCode.M));
        animator.SetBool("IsQuickAttack", Input.GetKey(KeyCode.N));
        animator.SetBool("IsLowAttack", Input.GetKey(KeyCode.B));
        animator.SetBool("IsImpacted", Input.GetKey(KeyCode.U));
        animator.SetBool("IsDefeated", Input.GetKey(KeyCode.Y));
    }
}

