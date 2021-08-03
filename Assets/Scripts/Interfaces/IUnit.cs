using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    void Stop();
    void Hold();
    void Move();
    void Attack();
}
