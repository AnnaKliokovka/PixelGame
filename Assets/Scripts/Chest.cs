using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;


    protected override void OnCollect()
    {
        //GameManager.instance.ShowText();
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+" + pesosAmount + " деняк", 20, Color.green,transform.position, Vector3.up*25,1.5f);
        }
    }
}