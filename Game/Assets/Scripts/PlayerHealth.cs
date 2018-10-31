﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public bool isDead = false;
    public Slider healthSlider;




    void Awake()
    {

        currentHealth = startingHealth;
    }

    void Update()
    {
        
        if (isDead == true)
        {
            Destroy(gameObject, 2f);
        }
    }

    public void TakeDamage(int amount)
    {

        currentHealth -= amount;

        healthSlider.value = currentHealth;


        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
    }





}