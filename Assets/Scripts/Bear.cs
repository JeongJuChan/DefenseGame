using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : LivingEntity
{
    void OnCollisionEnter(Collision collision)
    {
        collision.collider.GetComponent<IDamageable>().Damage(damage);
    }
}
