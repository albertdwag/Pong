using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Name;
    [SerializeField] private KeyCode moveUpKey;
    [SerializeField] private KeyCode moveDownKey;
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Image _playerImage;
    [SerializeField] private float moveSpeed = 10f;

    private void Update()
    {
        float inputY = Input.GetKey(moveUpKey) ? 1 : Input.GetKey(moveDownKey) ? -1 : 0;
        Vector2 movement = transform.up * inputY * moveSpeed;
        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    public void ChangeColor(Color color)
    {
        _playerImage.color = color;
    }

}
