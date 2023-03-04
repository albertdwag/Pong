using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _uiTextName;
    [SerializeField] private TMP_InputField _uiInputField;
    [SerializeField] private GameObject _changeNameInput;
    [SerializeField] private GameObject _confirmButton;
    [SerializeField] private Player _player;

    public void ConfirmName()
    {
        _player.Name = _uiInputField.text;
        _uiTextName.text = _player.Name;
        _changeNameInput.SetActive(true);
        _confirmButton.SetActive(false);
    }

    public void ChangeName()
    {
        _changeNameInput.SetActive(false);
        _confirmButton.SetActive(true);
    }
}
