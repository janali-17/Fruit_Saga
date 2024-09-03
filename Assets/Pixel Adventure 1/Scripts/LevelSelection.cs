using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    private Button[] lvlButtons;
    [SerializeField]
    private GameObject[] lvllock;
    // Start is called before the first frame update
    void Start()
    {
        lvllock[0].SetActive(false);
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        for(int i = 0; i < lvlButtons.Length; i++)
        {
            if(i+1 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }
            else if (lvlButtons[i] == true)
            {
                lvllock[i].SetActive(false);
            }
        }
    }
}
