using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    public Action<int> AttackEvent;

    public void OnAttackEvent(int damage)
    {
        AttackEvent?.Invoke(damage);
    }
}
