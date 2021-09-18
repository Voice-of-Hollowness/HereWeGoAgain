using System;
using Assets.Scripts;
using UnityEngine;

public abstract class LivingEntetity : MonoBehaviour, IAlive {

    public int startHealth;

    public int HP { get; private set; }

    protected bool dead;

    public event System.Action OnDeath;
    public event Action OnDamage;

    public virtual void Start()
    {
        HP = startHealth;
    }

    public virtual void TakeHit(int damage, Vector3 hitPoint = default, Vector3 hitDirect = default)
    {
        TakeDamage(damage);
    }

    public virtual void TakeDamage(int damage)
    {
       OnDamage?.Invoke();
        HP -= damage;
        if (HP <= 0 && !dead)
        {
            Die();
        }

    }
    public virtual void Die()
    {
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }
        GameObject.Destroy(gameObject);
    }
}
