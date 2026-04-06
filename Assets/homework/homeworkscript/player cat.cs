using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class playercat : MonoBehaviour
{
    public AudioSource audioSource;
    public float speed;
    public Animator Animator;

    public float x;
    public float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        

        Vector2 move = context.ReadValue<Vector2>();
        x = move.x;
        y = move.y;

        bool isRunning = move != Vector2.zero;

        Animator.SetBool("isrunning", isRunning);
       

    }

    public void OnFootstep()
    {
        audioSource.Play();
    }

}
