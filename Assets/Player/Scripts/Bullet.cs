using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float maxDistance = 15f;
    private Vector3 launchPosition;

    void Start()
    {
        launchPosition = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(launchPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}