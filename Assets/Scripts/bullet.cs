using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class bullet : Weapon
{
    protected override void AttackCollision(LivingEntetity collidedObj)
    {
        base.AttackCollision(collidedObj);
        Destroy(gameObject);
    }
}
