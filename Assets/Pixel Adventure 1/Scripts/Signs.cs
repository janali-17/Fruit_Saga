using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Signs : MonoBehaviour
{
    private Animator _animator;
    [SerializeField]
    private End_Level _endLevel;
    [SerializeField]
    private int nextSceneLoad;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Sign trigger");
            _animator.SetTrigger("End");
            _endLevel.End();
            if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt",nextSceneLoad);
            }
        }
    }
}
