using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Player player;
    public Ball Ball;
    public string goalTag = "Ball";
    public Scoreboard scoreboard;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == goalTag)
            CountPoint();
    }

    private void CountPoint()
    {
        Ball.ResetPosition();
        scoreboard.AddScore(player);
    }
}
