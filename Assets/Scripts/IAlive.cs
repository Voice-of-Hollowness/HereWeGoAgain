using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlive : IDamagable
{
    event Action OnDamage;
    event Action OnDeath;
    public int HP {get; }
}
