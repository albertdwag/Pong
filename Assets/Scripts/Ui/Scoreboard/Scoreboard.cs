using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    private TextMeshProUGUI _textPoints;
    private int _currentPoints;
    public int PointsToWin;

    private void Start()
    {
        _textPoints = gameObject.GetComponent<TextMeshProUGUI>();
        ResetScore();
    }

    public void AddScore(Player player)
    {
        _currentPoints++;
        _textPoints.text = _currentPoints.ToString();

        if (_currentPoints >= PointsToWin)
        {
            GameManager.Instace.EndGame();
            Highscore.Instance.SavePlayerWin(player);
        }
    }

    public void ResetScore()
    {
        _currentPoints = 0;
        _textPoints.text = _currentPoints.ToString();
    }
}
