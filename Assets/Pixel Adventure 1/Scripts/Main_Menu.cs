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
    [SerializeField] private Button ResetButton;


    private void OnEnable()
    {
        Start.onClick.AddListener(() => buttonCallBack(Start));
        Quit.onClick.AddListener(() => buttonCallBack(Quit));
        Level_1.onClick.AddListener(() => buttonCallBack(Level_1) );
        Level_2.onClick.AddListener(() => buttonCallBack(Level_2) );
        Level_3.onClick.AddListener(() => buttonCallBack(Level_3) );
        ResetButton.onClick.AddListener(() => buttonCallBack(ResetButton) );
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
            Time.timeScale = 1.0f;
        }
        else if (ButtonPressed == Level_3)
        {
            SceneManager.LoadScene(3);
            Time.timeScale = 1.0f;
        }
        else if(ButtonPressed == ResetButton) 
        { 
            PlayerPrefs.DeleteAll();
        }

    }
}
