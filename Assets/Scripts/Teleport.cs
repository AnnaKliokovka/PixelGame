using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("FloorCheck").GetComponent<Canvas>().enabled = true;
            //collision.gameObject.transform.position = pointTeleport.gameObject.transform.position + delta;
        }
    }
}
