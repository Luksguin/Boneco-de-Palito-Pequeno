using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForceX(-speed, ForceMode2D.Impulse);
    }
}
