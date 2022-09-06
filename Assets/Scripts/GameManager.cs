using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }


    //Resources
    public List<Sprite> weaponSprites;
    public List<int> xpTable;

    //References
    public Player player;

    //

    //Logic
    public int money;
    public int experience;

    /* 
     * INT money
     * INT exp 
     */
    public void SaveState()
    {
        string s = "";

        s += money.ToString() + "|";
        s += experience.ToString();

        PlayerPrefs.SetString("SaveState", s);
        //PlayerPrefs.Save();
        Debug.Log("Save");
        Debug.Log(s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;
        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        money = int.Parse(data[0]);
        experience = int.Parse(data[1]);
        Debug.Log("Loading");
    }
}
