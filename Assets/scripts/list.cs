using UnityEngine;

public class list : MonoBehaviour
{
    public GameObject[] players;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        for (int i = 0; i < players.Length; i++)
        {
            player playerScript = players[i].GetComponent<player>();
            playerScript.ResetPlayer();
        }
    }

    public void hitplayer()
    {
        for (int i = 0; i < players.Length; i++)
        {
            player playerScript = players[i].GetComponent<player>();
            playerScript.hit();
        }
    }
}
