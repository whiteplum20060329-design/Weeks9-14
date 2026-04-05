using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class hoe : MonoBehaviour
{
    // This script controls the hoe tool behavior, allowing the player to create land tiles when clicking.
    // It checks whether the position is valid, such as not placing in sky area and avoiding overlap
    // with existing tiles.
    // This prefab represents the land tile that gets created when using the hoe.
    // It is instantiated each time the player successfully places a new tile.
    public GameObject Prefab;
    public SpriteRenderer skyspriteRenderer;
    public List<Vector3> placedPositions;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hoetool()
    // This is the main hoe function, triggered when the player clicks.
    // It checks position validity, then whether placement is allowed, and finally spawns the tile.
    {
        if (skyspriteRenderer.bounds.Contains(transform.position) == false)
        // Used to detect if the current position is inside the sky area.
        // If the position is within this sprite bounds, land placement will be blocked.
        {

            bool canPlace = true;
            // This boolean determines whether placement is allowed.
            // It starts as true and will be set to false if any condition fails.

            for (int i = 0; i < placedPositions.Count; i++)
            // This list stores all positions where land tiles have already been placed.
            // It is used to prevent new tiles from spawning too close to existing ones.
            {
                float distance = Vector3.Distance(placedPositions[i], transform.position);

                if (distance < 1.5f)
                {
                    canPlace = false;
                }
            }

            if (canPlace == true)
            {
                GameObject land = Instantiate(Prefab, transform.position, Quaternion.identity);

                placedPositions.Add(transform.position);
                // If all checks pass, a new land tile is instantiated.
                // The position is then added to the list for future validation.
            }


        }
        }
    }
