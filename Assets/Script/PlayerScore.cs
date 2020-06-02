using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour

{

    public Text ScoreText;
    public Text ScoreOverText;
    public int scoreNumber;
    public float pointPerSec;
    public float scoreAmount;

    void Start()
    {
        scoreNumber = 0;
        scoreAmount = 0f;
        pointPerSec = 1f;
        
        ScoreOverText.text = PlayerPrefs.GetFloat("scoreNumber").ToString();
    }
        

    void Update()
    {
        ScoreText.text ="Score: " +(int)scoreAmount;
        scoreAmount += pointPerSec * Time.deltaTime;
        scoreNumber = (int)scoreAmount;
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("scoreNumber", scoreNumber);

    }
}
