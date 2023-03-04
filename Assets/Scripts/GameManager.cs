using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instace;

    private void Awake()
    {
        if (Instace == null)
            Instace = this;
        else
            Destroy(gameObject);
    }

    public void StartGame()
    {
        StateMachine.instance.SetState(StateMachine.State.Playing);
    }

    public void ShowMenu()
    {
        StateMachine.instance.SetState(StateMachine.State.Menu);
    }

    public void EndGame()
    {
        StateMachine.instance.SetState(StateMachine.State.EndGame);
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game button clicked!");
        Application.Quit();
    }
}
