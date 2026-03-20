using System;
using UnityEngine;

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

    public void ChangeSprite()
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
