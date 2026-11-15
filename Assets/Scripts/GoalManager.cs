using System;
using TMPro;
using UnityEngine;

public class GoalManager : MonoBehaviour
{


    public BoxCollider2D BC;


    public int score;

    public TMP_Text scoreText;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        score++;
        scoreText.SetText(score.ToString());

        if(col.TryGetComponent(out BallController ball))
        {
            ball.ResetBall();
        }

    }



}
