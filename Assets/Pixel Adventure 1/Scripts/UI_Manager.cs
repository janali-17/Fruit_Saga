using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private GameObject _Pause_Panel;

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
    }

    public void Pause_Button()
    {
        _Pause_Panel.SetActive(true);
        _animator.SetBool("IsPause", true);
        Time.timeScale = 0.0f;
    }
    public void Resume_Button()
    {
        _Pause_Panel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
