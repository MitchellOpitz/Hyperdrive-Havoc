using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int score = 100;
    public GameObject powerUpPrefab; // Placeholder for power-up prefab
    public float spawnChance = 0.1f; // 10% chance to spawn a power-up

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ScoreManager.Instance.AddScore(score);
        TrySpawnPowerUp();
        Destroy(gameObject);
    }

    void TrySpawnPowerUp()
    {
        if (Random.value < spawnChance)
        {
            Instantiate(powerUpPrefab, transform.position, Quaternion.identity);
        }
    }
}