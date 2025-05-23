using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {if (damage < 0)
    {
        throw new System.ArgumentOutOfRangeException("Damage cannot be negative");
    }
    else
    {

    
        health -= damage;
        if (health < 0)
            health = 0;
    }
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > 100)
            health = 100;
    }
    
}
