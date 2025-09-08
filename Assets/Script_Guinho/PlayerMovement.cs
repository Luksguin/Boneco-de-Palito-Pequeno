using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D myRb;

    private float _yDir;

    private void FixedUpdate()
    {
        Movement();
    }

    private void OnMove(InputValue inputValue)
    {
        _yDir = inputValue.Get<Vector2>().y;
    }

    private void Movement()
    {
        myRb.linearVelocityY = _yDir * speed * Time.deltaTime;
    }
}
