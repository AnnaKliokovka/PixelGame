using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPlace : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        GameManager.instance.SaveState();
    }
}
