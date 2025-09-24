using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    // Variables
    public float health;
    public float maxHealth;
    public Image healthBar;
    public float stamina;
    public float maxStamina;
    public Image staminaBar;

    void Start()
    {
        // Initial Health Pool
        maxHealth = 100;
        health = maxHealth;

        // Initial Stamina Pool
        maxStamina = 100;
        stamina = maxStamina;
    }

    void Update()
    {
        // Health Bar
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        // Health check
        if(health <= 0)
        {
            Destroy(gameObject);
        }

        // Stamina Regen
    }
}
