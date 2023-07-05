using UnityEngine;

public class BouncePadComponent : MonoBehaviour
{
    [SerializeField] private float bounceForce;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce,ForceMode2D.Impulse);
        }
    }
}
