using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signs : MonoBehaviour
{
    private Animator _animator;
    [SerializeField]
    private End_Level _endLevel;

    private void Start()
    {
       // _endLevel = GameObject.Find("End_Level").GetComponent<End_Level>();
        _animator = GetComponent<Animator>();
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
        if ( _endLevel == null )
        {
            Debug.Log("End level in signs is null");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Sign trigger");
            _animator.SetTrigger("End");
            _endLevel.End();
        }
    }
}
