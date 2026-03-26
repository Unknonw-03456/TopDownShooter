using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") )
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Destruir bala si se aleja demasiado
        Destroy(gameObject, 3f);
    }
}