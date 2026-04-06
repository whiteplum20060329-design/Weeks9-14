using UnityEngine;

public class seedbag2 : MonoBehaviour
{
    public GameObject appleseed;
    public toolsystem toolsystems;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void apple()
    {
        if (toolsystems.toollist == 2)
        {
           GameObject apple = Instantiate(appleseed, transform.position, Quaternion.identity);

            plantgrow plantgrow = apple.GetComponent<plantgrow>();


            plantgrow.toolsystem = toolsystems;

        }
    }
}
