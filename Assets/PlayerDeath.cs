using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGameObject = collision.gameObject;
        if (otherGameObject.CompareTag("Enemy"))

        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        Destroy(gameObject);
    }
}

