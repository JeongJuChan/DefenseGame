using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
    [SerializeField] protected int damage = 10;
    [SerializeField] protected int health = 10;
    public int Health { get => health; set => health = value; }

    public virtual void Damage(int amount)
    {
        health -= amount;
    }
    
     
}
