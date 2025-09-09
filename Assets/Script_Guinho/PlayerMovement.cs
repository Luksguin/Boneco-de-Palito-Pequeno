using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody2D myRb;
    public Animator myAnimator;

    public GameObject mySprite;
    public GameObject explosion;

    private float _yDir;
    private float _time;

    private void Update()
    {
        if(Time.time > 30f)
        {
            

            Invoke("StopGame", 1f);
        }
    }

    private void OnJump()
    {
        Quit();
    }

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Obstaculo")
        {
            myAnimator.SetBool("Caboom", true);

            Destroy(mySprite, 0.55f);

            Invoke("StopGame", 1f);
        }
    }

    private void StopGame()
    {
        Time.timeScale = 0;
    }

    private void Quit()
    {
        print("foi");
        Application.Quit();
    }
}
