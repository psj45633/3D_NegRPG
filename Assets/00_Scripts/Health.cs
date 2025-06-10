using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int maxMana = 100;
    public int health;
    public int mana;
    public event Action OnDie;

    public bool isDie = false;
    void Start()
    {
        health = maxHealth;
        mana = maxMana;
    }

    public void TakeDamage(int damage)
    {
        if (health == 0) return;

        health = Mathf.Max(health - damage, 0);

        if(health == 0)
        {
            isDie = true;
            OnDie?.Invoke();
        }

        print(health);
    }


    public void RestoreStatValue(int condition,int value)
    {
        if (condition >= 100) return;

        condition = Mathf.Min(condition + value, 100);
    }
}
