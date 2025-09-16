using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            player.GetComponent<Rigidbody>().AddForce(Vector3.up * player.JumpForce * 2);
        }
    }
}
