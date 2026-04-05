using UnityEngine;

public class seedbag2 : MonoBehaviour
{
    public GameObject appleseed;
    public toolsystem toolsystem;
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
        if (toolsystem.toollist == 2)
        {
            Instantiate(appleseed, transform.position, Quaternion.identity);
        }
    }
}
