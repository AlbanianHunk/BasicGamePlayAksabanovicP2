using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // show originl amount of lives and score here
        UpdateStats();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateStats();
    }
    public void LifeDown()
    {
        lives--;
        UpdateStats();
    }

    public void UpdateStats()
    {
        if (lives <= 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Lives: " + lives + " | Score: " + score);
        }

    }
}