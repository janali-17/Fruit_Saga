using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class Main_Menu : MonoBehaviour
{
    [SerializeField]
    private Button Start;
    [SerializeField]
    private Button Quit;
    [SerializeField]
    private Button Level_1;
    [SerializeField]
    private Button Level_2;
    [SerializeField]
    private Button Level_3;

    [SerializeField]
    private GameObject[] Locks;
    [SerializeField]
    private int _level;
    [SerializeField]
    private bool _status;


    private void OnEnable()
    {
        Start.onClick.AddListener(() => buttonCallBack(Start));
        Quit.onClick.AddListener(() => buttonCallBack(Quit));
        Level_1.onClick.AddListener(() => buttonCallBack(Level_1) );
        Level_2.onClick.AddListener(() => buttonCallBack(Level_2) );
        Level_3.onClick.AddListener(() => buttonCallBack(Level_3) );
    }

   
    private void buttonCallBack(Button ButtonPressed)
    {
        if(ButtonPressed == Start)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1.0f;
        }
        else if(ButtonPressed == Quit)
        {
            Application.Quit();
        }
        else if(ButtonPressed == Level_1)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1.0f;
        }
        else if (ButtonPressed == Level_2)
        {
            SceneManager.LoadScene(2);
        }
        else if (ButtonPressed == Level_3)
        {
            Debug.Log("Level - 3");
        }
    }
    public void Lock(bool status, int level)
    {
        _status = status;
        _level = level;
    }
}
