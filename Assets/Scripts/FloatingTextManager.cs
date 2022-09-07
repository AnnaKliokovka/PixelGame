using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextManager : MonoBehaviour
{
    public GameObject textConteiner;
    public GameObject textPrefab;

    private List<FloatingText> floatingTexts = new List<FloatingText>();
    
    public void Show(string msg, int funcSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        FloatingText floatingText = GetFloatingText();
        floatingText.txt.text = msg;
        floatingText.txt.fontSize = funcSize;
        floatingText.txt.color = color;

        floatingText.go.transform.position =  Camera.main.WorldToScreenPoint(position);
        floatingText.motion = motion;
        floatingText.duration = duration;
        floatingText.Show();    

    }
    
    private FloatingText GetFloatingText()
    {
        FloatingText txt = floatingTexts.Find(t => !t.active);
        if(txt == null)
        {
            txt = new FloatingText();
            txt.go = Instantiate(textPrefab);
            txt.go.transform.SetParent(textConteiner.transform);
            txt.txt = txt.go.GetComponent<TMPro.TMP_Text>();
            floatingTexts.Add(txt);
        }
        return txt;
    }

    private void Update()
    {
        foreach (FloatingText txt in floatingTexts)
            txt.UpdateFloatingText();
    }
}
