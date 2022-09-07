using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        //GameManager.instance.ShowText("Приветик!", 20, Color.green, transform.position, Vector3.up * 50, 3.0f);
    }
}
