using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBase : MonoBehaviour
{

    [Header("Player Stats")]
    [SerializeField] private float playerHealth = 100f; //All the player stats so far
    [SerializeField] private float playerStamina = 100f;
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpHeight = 3f;
    
    public void updateHealth(float amount)
    {
        playerHealth = Mathf.Clamp(playerHealth - amount, 0, 100f); //Stops the player's health from falling below 0 or over 100
    }

    public void updateStamina(float amount)
    {
        playerStamina = Mathf.Clamp(playerStamina - amount, 0, 100f);
    }
    public float gethealth() //Our getter and setter functions for each
    {
        return playerHealth;
    }

    public float getStamina()
    {
        return playerStamina;
    }

    public float getSpeed()
    {
        return playerSpeed;

    }
    public float getJumpheight()
    {
        return jumpHeight;
    }

    public void setJumpHeight(float jh)
    {
        jumpHeight = jh;
    }
    public void setHealth(float health)
    {
        playerHealth = health;
    }

    public void setStamina(float stamina)
    {
        playerStamina = stamina;
    }

    public void setSpeed(float speed) {
        playerSpeed = speed;
    
    
    }
}
