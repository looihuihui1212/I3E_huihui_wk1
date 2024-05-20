using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject coolTextBox;

    int currentScore = 0;

    public void IncreaseScore(int scoreToAdd)
    {
        coolTextBox.SetActive(true);// enable game object
        //coolTextBox.SetActive(false);
        currentScore += scoreToAdd;
        scoreText.text = "HP:" + currentScore.ToString();
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
