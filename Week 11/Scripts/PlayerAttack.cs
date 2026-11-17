using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    void Attack()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else if (Keyboard.current.rKey.isPressed)
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }
}
