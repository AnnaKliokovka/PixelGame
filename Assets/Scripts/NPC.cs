using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        print("Talking...");
    }
}