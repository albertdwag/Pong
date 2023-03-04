using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public string bounceTag = "Player";
    public Vector2 velocity = new Vector2(1, 1);
    private Vector3 _startPosition;
    private bool _canMove = false;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (!_canMove) return;
        transform.Translate(velocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        velocity.x *= (collision.gameObject.tag == bounceTag) ? -1 : 1;
        velocity.y *= (collision.gameObject.tag != bounceTag) ? -1 : 1;
    }

    public void ResetPosition()
    {
        transform.position = _startPosition;
        _canMove = false;
    }

    public void CanMove(bool state)
    {
        _canMove = state;
    }
}
