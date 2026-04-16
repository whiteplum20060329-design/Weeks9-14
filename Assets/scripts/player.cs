using UnityEngine;

public class player : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth = 5;

    public bool isDead = false;

    public SpriteRenderer spriteRenderer;
    public Color normalColor;
   public GameObject playerpl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0f, 0f, 10f) * Time.deltaTime;
    }

    public void ResetPlayer()
    {
        currentHealth = maxHealth;
        isDead = false;
        spriteRenderer.color = normalColor;
        playerpl.SetActive(true);
    }

    public void hit() {

        currentHealth -- ;

        if (currentHealth == 0)
        {
            isDead = true;

        }

        if (isDead == true)
        {
            playerpl.SetActive(false);

          
        }


    }


}
