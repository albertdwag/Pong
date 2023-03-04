using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StateMachine : MonoBehaviour
{
    public enum State
    {
        Menu,
        Playing,
        EndGame
    }

    public static StateMachine instance;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _endGameScreen;
    [SerializeField] private Ball _ball;
    [SerializeField] private Scoreboard[] _scoreboards;
    private State _currentState = State.Menu;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        switch (_currentState)
        {
            case State.Menu:
                MenuState();
                break;
            case State.Playing:
                PlayingState();
                break;
            case State.EndGame:
                EndGameState();
                break;
        }
    }

    private void MenuState()
    {
        _endGameScreen.SetActive(false);
        _menu.SetActive(true);
        _ball.ResetPosition();
    }

    private void PlayingState()
    {
        _menu.SetActive(false);
        _ball.CanMove(true);
    }
    private void EndGameState()
    {
        _endGameScreen.SetActive(true);
        _ball.CanMove(false);
        foreach (var scoreboard in _scoreboards)
            scoreboard.ResetScore();
    }

    public void SetState(State newState)
    {
        _currentState = newState;
    }
}
