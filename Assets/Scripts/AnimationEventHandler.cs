using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    public Action EquipEvent;
    public Action UnEquipEvent;

    public Action<int> AttackEvent;

    private void Start()
    {
    }

    public void OnAttackEvent(int damage)
    {
        AttackEvent?.Invoke(damage);
    }

    public void OnEquip()
    {
        EquipEvent?.Invoke();
    }

    public void OnUnEquip()
    {
        UnEquipEvent?.Invoke();
    }
}
