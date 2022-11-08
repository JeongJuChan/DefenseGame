using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : LivingEntity, IDamageable
{
    Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void OnCollisionEnter(Collision collision)
    {
        collision.collider.GetComponent<IDamageable>().Damage(damage);

    }

    public void Damage(int amount)
    {
        health -= amount;

        // �������� ���� �ǰ� �ִϸ��̼� ó��
        // �ִϸ����� ���� ��� or . . ����ó�� 

        if(amount <= 10) {

            Debug.Log(amount +"�� �������� ���� !!");
            anim.SetTrigger("lowHit");
        }

    }
}
