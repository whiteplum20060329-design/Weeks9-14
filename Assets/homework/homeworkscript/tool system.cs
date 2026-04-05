using UnityEngine;
using UnityEngine.InputSystem;

public class toolsystem : MonoBehaviour
{//// player tool system script,handles tool switching, following mouse position, and using tools
    public GameObject[] tools;

    // This array stores all tool GameObjects such as hoe, watering , seed bag.
    // Tool switching is done by set active these objects
    public int toollist = 0;
    public Transform toolpos;
    public Vector3 mousepos;

    public hoe hoe;
  public bool useSeed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        showcurrenttool();
    }

    // Update is called once per frame
    void Update()
    {
        toolpos.position = mousepos;
    }

    // This function is called by the PlayerInput Interact event
    public void toolmove(InputAction.CallbackContext context)
    {




        Vector2 mouseScreenPos = context.ReadValue<Vector2>();
        mousepos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        mousepos.z = 0;


    }

    public void usetool(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (toollist == 0)
            {
                hoe.hoetool();
                // Reference to the hoe script, used to trigger the hoe action.
                // When the current tool is the hoe, this reference is used to call its function.
            }
            else if (toollist == 1)
            {

                useSeed = true;//set it to true so can check the plantgrow event
            }
            else if (toollist == 2)
            {
                useSeed = true;
            }
            else if (toollist == 3)
            {

            }
            else if (toollist == 4)
            {

            }
        }
    }










    public void changetool(InputAction.CallbackContext context)
    {
        // Used to switch tools by increasing the index each time.
        // When exceeding the array length, it resets to 0 to create a loop.
        if (context.performed)
        {

            toollist++;   
            Debug.Log(toollist);


            if (toollist > tools.Length)
            {
                toollist = 0;
            }

            showcurrenttool();
            Debug.Log("Current Tool: " + toollist);

        }

       

    }

 public void showcurrenttool()

    // Loops through all tools and activates only the current one based on index.
    // Ensures only one tool is visible in the scene at a time.
    {
        for (int i = 0; i < tools.Length; i++)
        {
            if (i == toollist)
            {
                tools[i].SetActive(true);
            }
            else
            {
                tools[i].SetActive(false);
            }
        }

    }

  

    }
