using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class plantgrow : MonoBehaviour
{
    public AnimationCurve growCurve;

    public float duration;

    public float progress = 0f;

    public Sprite seedsprite;
   public Sprite growsprite;

    private SpriteRenderer spriteRenderer;
    private Coroutine growCoroutine;
    public bool isWatering = false;

    public toolsystem toolsystem;

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Get the SpriteRenderer component from this GameObject.
        // This allows the script to control which sprite is displayed.
       // Set the plant's starting sprite to the seed sprite.
        // This means the plant begins as a seed before any watering happens.
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = seedsprite;
        //toolsystem = GetComponent<toolsystem>();
    }

    // Update is called once per frame
    void Update()
    {
        water();

        Debug.Log("usewater: " + toolsystem.usewater);


    }


    public void water()
    {
        // This function handles the main watering logic for the plant.
        // It decides when the plant should start growing and when it should stop.


        // If the player is using the watering can and the tool is in use
        // trigger the event to start growing
        if (toolsystem.usewater == true)
        {
            StartGrowing();
        }

        // If watering has stopped or the tool is no longer in use
        // trigger the event to stop growing
        if (isWatering == true && toolsystem.usewater == false )
        {
            StopGrowing();
        }
    }

    public void StartGrowing()
    {
        // This function starts the growth process.
        // It only starts the coroutine if the plant is not already growing.
        if (isWatering == false)
        {
            // Check if the plant is not already in the watering state.
            // This prevents multiple coroutines from starting at the same time.
            isWatering = true;
            growCoroutine = StartCoroutine(GrowPlant());
            // Start the GrowPlant coroutine and save its reference.
            // This allows the plant to grow over multiple frames instead of instantly.
        }
    }

    public void StopGrowing()
    {
        // Only stop if the plant is currently in the watering state.
         // Mark the plant as no longer being watered.
            if (isWatering == true)
        {
            isWatering = false;

            if (growCoroutine != null)
            {
                StopCoroutine(growCoroutine);
            }
        }
    }

    IEnumerator GrowPlant()
    {
       
            yield return new WaitForSeconds(2f);
            spriteRenderer.sprite = growsprite;
            // Wait for 2 seconds before changing the seed sprite.
            // This creates a small delay so the growth does not happen instantly.
        

        while (progress < duration)
        {
            progress += Time.deltaTime;
            transform.localScale = growCurve.Evaluate(progress / duration) * Vector3.one;
            yield return null;
        }
    }


}
