using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    public static Highscore Instance;
    public TextMeshProUGUI uiTextHighscore;

    private string playerNameKey = "keyHighscore";

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        UpdateUI();
    }

    public void SavePlayerWin(Player player)
    {
        PlayerPrefs.SetString(playerNameKey, player.Name);
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (PlayerPrefs.HasKey(playerNameKey))
            uiTextHighscore.text = PlayerPrefs.GetString(playerNameKey);
        else
            uiTextHighscore.text = "Nenhum";
    }
}
