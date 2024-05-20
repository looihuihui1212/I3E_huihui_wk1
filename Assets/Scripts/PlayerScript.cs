using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    int currentScore = 0;

    // whenever player touch coin, player score will increase by myScore variable
    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
