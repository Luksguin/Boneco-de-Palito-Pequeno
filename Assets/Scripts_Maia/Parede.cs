using UnityEngine;

public class Parede : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.transform.parent.gameObject);
    }
}
