using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreCounter : MonoBehaviour
{

    public float PlayerScore = 0f;
    public Text scoreText;

    private void Awake()
    {
        int ScoreCount = FindObjectsOfType<ScoreCounter>().Length;

        if(ScoreCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Hurdle")
        {
            PlayerScore += 1f;
            scoreText.text = PlayerScore.ToString();
        }
    }

    public void DestroySession()
    {
        Destroy(gameObject);
    }

}
