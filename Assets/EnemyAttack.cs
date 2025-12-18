using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 20;
    public float attackRate = 1f;
    private float nextAttackTime = 0f;

    public GameObject player; // Assign the player in Inspector
    public float attackRange = 3f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= attackRange && Time.time >= nextAttackTime)
        {
            AttackPlayer();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void AttackPlayer()
    {
        if (player == null) return;

        PlayerHealth ph = player.GetComponent<PlayerHealth>();
        if (ph != null)
        {
            Debug.Log($"Enemy attacking! Player shield status: {ph.isProtected}");
            ph.TakeDamage(damage);
        }
        else
        {
            Debug.LogWarning("PlayerHealth not found on player!");
        }
    }
}



