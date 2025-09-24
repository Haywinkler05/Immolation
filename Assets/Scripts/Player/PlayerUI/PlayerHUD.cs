using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    // Variables

    public Slider healthBar;
    public Slider staminaBar;
    private PlayerBase playerBase;

    public void HealthStartBar()
    {
        healthBar.maxValue = playerBase.gethealth();
        healthBar.value = playerBase.gethealth();
    }
    public void StaminaStartBar()
    {
        staminaBar.maxValue = playerBase.getStamina();
        staminaBar.value = playerBase.getStamina();
    }
    public void SetHealthBar()
    {
        healthBar.value = playerBase.gethealth();
    }
    public void SetStaminaBar()
    {
        healthBar.value = playerBase.getStamina();
    }
}
