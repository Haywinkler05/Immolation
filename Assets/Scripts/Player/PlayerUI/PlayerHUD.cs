using JetBrains.Annotations;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    // Variables

    public Slider healthBar;        // Slider component of the game object
    public Slider staminaBar;
    private PlayerBase playerBase;

    // Detects for Script Enable
    private void OnEnable()
    {
        // Locks Cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Detects for Script Disable
    private void OnDisable()
    {
        // Unlocks Cursor
        Cursor.lockState = CursorLockMode.None;
    }
    // Custom Functions
    public void HealthStartBar()
    {
        // Caps the Slider
        healthBar.maxValue = playerBase.gethealth();
        // Sets the Slider's initial value
        healthBar.value = playerBase.gethealth();
    }
    public void StaminaStartBar()
    {
        // Caps the Slider
        staminaBar.maxValue = playerBase.getStamina();
        //Sets the Slider's initial value
        staminaBar.value = playerBase.getStamina();
    }
    public void SetHealthBar()
    {
        // Sets the slider value
        healthBar.value = playerBase.gethealth();
    }
    public void SetStaminaBar()
    {
        // Sets the slider value
        healthBar.value = playerBase.getStamina();
    }
}
