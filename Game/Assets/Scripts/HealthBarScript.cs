using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarScript : MonoBehaviour
{
    public Slider healthSlider;
    public TextMeshProUGUI healthText;
    
    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }
    public void setHealth(int health)
    {
        healthSlider.value = health;
        healthText.text = health.ToString();
    }

    public void LateUpdate()
    {
        setHealth(((int)healthSlider.value));
    }
}
