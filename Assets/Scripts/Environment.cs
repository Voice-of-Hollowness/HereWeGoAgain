using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour,IDamagable
{
    public event Action OnVisualFx ;


    public void TakeHit(int damage, Vector3 hitPoint = default, Vector3 hitDirect = default)
    {
        throw new NotImplementedException();
        OnVisualFx?.Invoke();
    }
}
