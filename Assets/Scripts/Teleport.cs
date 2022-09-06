using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject.Find("FloorCheck").GetComponent<Canvas>().enabled = true;
            //collision.gameObject.transform.position = pointTeleport.gameObject.transform.position + delta;
        }
    }
}
