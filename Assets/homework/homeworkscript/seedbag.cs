using UnityEngine;

public class seedbag : MonoBehaviour
{
    public GameObject sunflowerseed;
    public toolsystem toolsystem;
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
        if (toolsystem.toollist == 1)
        {
            Instantiate(sunflowerseed, transform.position, Quaternion.identity);
        }
    }
}
