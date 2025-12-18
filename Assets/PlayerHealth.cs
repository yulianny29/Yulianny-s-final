using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isProtected = false;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"TakeDamage called! Shield: {isProtected}, Damage: {damage}");

        if (isProtected)
        {
            Debug.Log("Shield is active! No damage taken.");
            return; // Shield blocks all damage
        }

        currentHealth -= damage;
        Debug.Log($"Player took {damage} damage. Current health: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
    }
}
