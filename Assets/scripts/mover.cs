using UnityEngine;
using UnityEngine.InputSystem;

public class mover : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 moveway;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)moveway* speed * Time.deltaTime;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveway= context.ReadValue<Vector2>();
    }
}