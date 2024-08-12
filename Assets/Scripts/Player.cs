using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public Slider _slider;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth; 
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }

    void Update()
    {
        //test if dmg is taken
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(5f);
        }
    }

    //To calculate current health after dmg taken
    void TakeDamage(float dmg){
        currentHealth -= dmg;
        _slider.value = currentHealth;
    }
}
