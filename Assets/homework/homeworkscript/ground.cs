using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ground : MonoBehaviour
{
    public UnityEvent plantgrow;
    private SpriteRenderer spriteRenderer;
    public toolsystem toolsystem;
    private bool hasPlanted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Get the SpriteRenderer component attached to this object
        // so we can use its bounds for detecting if the tool is on the ground.
    }

    // Update is called once per frame
    void Update()
    {
        bool inground = spriteRenderer.bounds.Contains(toolsystem.toolpos.position);
        // Check if the tool position is inside this ground tile

        // Conditions for planting:
        // 1. The tool is inside this ground tile
        // 2. This tile has not been planted yet
        // 3. The player has just used a seed tool
        if (inground && hasPlanted == false && toolsystem.useSeed == true)
        {
            plantgrow.Invoke();
            hasPlanted = true;
            // Mark this tile as planted so it cannot be used again
            toolsystem.useSeed = false;
            // Reference to the tool system.
            // Used to check which tool is currently selected and the tool position.
            //
        }
    }




}
