using UnityEngine;

public class PlayerDamageScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private int fallDamage = 0;
    private const int fallDamageThreshold = 5;
    public HealthScript healthBar;

    private Vector3 FrameVelocity { get; set; }
    private Vector3 CurrentFrameVelocity { get; set; }
    private Vector3 PreviousPosition { get; set; }


    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if(Time.timeScale > 0f) {
            CurrentFrameVelocity = (transform.position - PreviousPosition) / Time.deltaTime;
            FrameVelocity = Vector3.Lerp(FrameVelocity, CurrentFrameVelocity, 0.1f);
            if (fallDamage < -(int)FrameVelocity.y)
            {
                fallDamage = -(int)FrameVelocity.y;
            }
            if ((int)FrameVelocity.y >= -0.3f && (int)FrameVelocity.y <= 0.3f && fallDamage > fallDamageThreshold)
            {
                int damage = MapInt(fallDamage, 6, 70, 8, 100);
                TakeDamage(damage);
                fallDamage = 0;
            }
            PreviousPosition = transform.position;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().RestartCurrentLevel();
        }
    }

    private int MapInt(int x, int minIn, int maxIn, int minOut, int maxOut)
    {
        return (x - minIn) * (maxOut - minOut) / (maxIn - minIn) + minOut;
    }
}
