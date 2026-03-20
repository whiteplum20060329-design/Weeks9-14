using UnityEngine;
using UnityEngine.InputSystem;

public class prefeblist : MonoBehaviour
{
    public GameObject[] gameObjects;
    private int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function is called by the PlayerInput Interact event
    public void prefeb(InputAction.CallbackContext context)
    {

      


        // Check if the input action is performed ,prevents continuous triggering when holding the key
        if (context.performed)
        {

            Vector2 mouseScreenPos = Mouse.current.position.ReadValue();
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
            mousepos.z = 0;

            Instantiate(gameObjects[index], mousepos, Quaternion.identity);


            

            
        }

    }

    public void change(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            index++;    // Increase index to move to the next 


            if (index >= gameObjects.Length)
            {
                index = 0;// If index goes beyond the array length
                          // Reset index to 0
            }
        }

    }
}
