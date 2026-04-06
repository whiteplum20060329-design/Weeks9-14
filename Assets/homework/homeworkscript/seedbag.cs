using UnityEngine;
using UnityEngine.Events;

public class seedbag : MonoBehaviour
{
    public GameObject sunflowerseed;
    public toolsystem toolsystems;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sunflower()
    {
        if (toolsystems.toollist == 1)
        {
           GameObject sunflower = Instantiate(sunflowerseed, transform.position, Quaternion.identity);
           
            plantgrow plantgrow = sunflower.GetComponent<plantgrow>();


            plantgrow.toolsystem = toolsystems;
            
        

           
            
           


        }
    }
}
