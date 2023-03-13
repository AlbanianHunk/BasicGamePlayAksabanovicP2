using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int scoreValue;
    // reference to playerstats
    public PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        //  get playerstats fom wich ever object has it
        playerStats = GameObject.FindObjectOfType(typeof(PlayerStats)) as PlayerStats;
        playerStats.UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // get reference to collider (to find the trigger one)
        Collider m_col = gameObject.GetComponent<Collider>();

        if (other.name != "Player" && m_col.isTrigger)
        {
            playerStats.AddScore(1);
            Destroy(gameObject);
            Destroy(other);
        }
        else if (other.name == "Player") 
        {
            playerStats.LifeDown();
        }
    }
}

