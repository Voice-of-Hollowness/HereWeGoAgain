using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using NUnit.Framework;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.TestTools;

public class VariousTest
{
    private LivingEntetity _enemy;
    private Environment _environment;
    private Weapon _bullet;


    [SetUp]
    public void Init()
    {
        var go1 = GameObject.Instantiate(new GameObject("TestObject2"));
        var go = GameObject.Instantiate(new GameObject("TestObject"));
        _environment = go.AddComponent<Environment>();
        _enemy =  go.AddComponent<Enemy>();
        _enemy.startHealth = 10;
        _enemy.Start();
        _bullet = go1.AddComponent<bullet>();
        _bullet.damage = 2;
    }


    [Test]
    public void EnemyDamageTest()
    {
        _enemy.OnDamage += Assert.Pass;
        _enemy.TakeHit(1);
        Assert.Fail();
    }
    [Test]
    public void EnvironmentDamageTest()
    {
        _environment.OnVisualFx += Assert.Pass;
        _environment.TakeHit(1);
        Assert.Fail();
    }

    [Test]
    public void EnemyDamageWithWeaponTest()
    {
        _enemy.OnDamage += Assert.Pass;
        _bullet.CheckCollision(_enemy.gameObject);
        Assert.Fail();
    }
}
