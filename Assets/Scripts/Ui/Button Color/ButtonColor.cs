using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Image _uiImage;
    [SerializeField] private Player _player;

    private void OnValidate()
    {
        _uiImage = GetComponent<Image>();
    }

    private void Start()
    {
        _uiImage.color = _color;
    }

    public void ChangePlayerColor()
    {
        _player.ChangeColor(_color);
    }
}
