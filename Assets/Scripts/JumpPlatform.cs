using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    private Animator animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            animator = player.GetComponent<Animator>();
            player.GetComponent<Rigidbody>().AddForce(Vector3.up * player.JumpForce * 2);
            animator.SetTrigger("Jump");
        }
    }
}
