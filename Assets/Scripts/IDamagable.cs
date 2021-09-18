using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void TakeHit(int damage, Vector3 hitPoint = default, Vector3 hitDirect = default);
}
