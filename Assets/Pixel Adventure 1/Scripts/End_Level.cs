using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_Level : MonoBehaviour
{
    [SerializeField]
    private Button Main;
    [SerializeField]
    private Button Quit;
    [SerializeField]
    private Button Next;
    [SerializeField]
    private Button Restart;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }
    private void OnEnable()
    {
        Main.onClick.AddListener(() => buttonCallBack(Main));
        Restart.onClick.AddListener(() => buttonCallBack(Restart));
        Quit.onClick.AddListener(() => buttonCallBack(Quit));
        Next.onClick.AddListener(() => buttonCallBack(Next));
    }

    private void buttonCallBack(Button ButtonPressed)
    {
        if (ButtonPressed == Main)
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }
        else if (ButtonPressed == Quit)
        {
            Application.Quit();
        }
        else if (ButtonPressed == Restart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1.0f;
        }
        else if (ButtonPressed == Next)
        {

            if(SceneManager.GetActiveScene().name == "Level_1")
            {
                SceneManager.LoadScene(2);
                Time.timeScale = 1.0f;
            }
            else if (SceneManager.GetActiveScene().name == "Level_2")
            {
                SceneManager.LoadScene(3);
                Time.timeScale = 1.0f;
            }
        }
    }

    public void End()
    {
        _animator.SetBool("IsEnd", true);
        StartCoroutine(EndWait());      
    }

    IEnumerator EndWait()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0.0f;
        yield return new WaitForSeconds(2);
    }
}
