using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class changer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
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
    public void ChangeSprite(InputAction.CallbackContext context)
    {
        // Check if the input action is performed ,prevents continuous triggering when holding the key
        if (context.performed)
        {
            index++;    // Increase index to move to the next sprite

            if (index >= sprites.Length)
            {
                index = 0;// If index goes beyond the array length
                          // Reset index to 0
            }

            spriteRenderer.sprite = sprites[index];    // Set the sprite based on the current index
        }

    }

}
