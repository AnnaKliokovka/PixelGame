using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorMenu : MonoBehaviour
{
    public List<Button> Buttons;
    public List<GameObject> Teleporters;
    private int lastFloor = 1;
    void Start()
    {
        Buttons[Camera.main.GetComponent<SchoolInfo>().FloorNow - 1].GetComponent<Button>().interactable = false;
    }

    public void GoToFloor(int n)
    {
        Buttons[Camera.main.GetComponent<SchoolInfo>().FloorNow - 1].GetComponent<Button>().interactable = true;
        GameObject.Find("FloorCheck").GetComponent<Canvas>().enabled = false; 
        lastFloor = n;
        Camera.main.GetComponent<SchoolInfo>().FloorNow = n;
        GameObject.Find("player_0").transform.position = Teleporters[lastFloor-1].transform.position + new Vector3(0.4f, 0, 0);
        Buttons[Camera.main.GetComponent<SchoolInfo>().FloorNow - 1].GetComponent<Button>().interactable = false;

    }
    public void Cancel()
    {
        GameObject.Find("FloorCheck").GetComponent<Canvas>().enabled = false;
    }
}
