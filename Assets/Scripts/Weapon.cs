using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Weapon : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter(Collision other)
    {
        CheckCollision(other.gameObject);
    }

    public void CheckCollision(GameObject otherGameObject)
    {
        var living = otherGameObject.GetComponent<LivingEntetity>();
        if (living != null)
        {
            AttackCollision(living);
        }
    }

    protected virtual void AttackCollision(LivingEntetity collidedObj)
    {
        collidedObj.TakeHit(damage);
    }
}