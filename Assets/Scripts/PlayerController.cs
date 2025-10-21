using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Скорость движения
    public float Speed = 5f;
    public float JumpForce = 300f;
    public int coins = 0;
    public Vector3 MoveDirection = Vector3.right;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Движение влево-вправо
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Speed* Time.deltaTime, 0, 0);

        if (horizontal > 0)
            transform.rotation = Quaternion.LookRotation(MoveDirection);
        else if (horizontal < 0)
            transform.rotation = Quaternion.LookRotation(-MoveDirection);

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Rumba");
        }

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpForce);
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene"); // SampleScene - это название файла сцены, которая откроется
            
        }
    }
}