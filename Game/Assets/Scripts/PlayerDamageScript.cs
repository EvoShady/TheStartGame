using UnityEngine;

public class PlayerDamageScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthScript healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().RestartCurrentLevel();
        }
    }
}
