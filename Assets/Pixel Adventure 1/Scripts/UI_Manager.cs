using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private GameObject _Pause_Panel;
    [SerializeField]
    private Button Resume;
    [SerializeField]
    private Button Main;
    [SerializeField]
    private Button Quit;
    [SerializeField]
    private Button Pause_Button;
    [SerializeField]
    private Button Restart;

    private static UI_Manager _instance;
    public static UI_Manager Instance
    {
        set { }
        get {
            if (_instance == null)
            {
                Debug.Log("UI instance is Null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
        //Scene ActiveScene = SceneManager.GetActiveScene();
    }
    private void OnEnable()
    {
        Resume.onClick.AddListener(() => buttonCallBack(Resume));
        Pause_Button.onClick.AddListener(() => buttonCallBack(Pause_Button));
        Main.onClick.AddListener(() => buttonCallBack(Main));
        Restart.onClick.AddListener(() => buttonCallBack(Restart));
        Quit.onClick.AddListener(() => buttonCallBack(Quit));

    }
    private void buttonCallBack(Button ButtonPressed)
    {
        if(ButtonPressed == Resume)
        {
            _Pause_Panel.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else if(ButtonPressed == Pause_Button)
        {
            _Pause_Panel.SetActive(true);
            _animator.SetBool("IsPause", true);
            Time.timeScale = 0.0f;
        }
        else if(ButtonPressed == Main)
        {
            SceneManager.LoadScene(0);
        }
        else if(ButtonPressed == Restart)
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(ButtonPressed == Quit)
        {
            Application.Quit();
        }
    }
}
