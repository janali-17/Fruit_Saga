using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Traps : MonoBehaviour
{
  

    private void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }

   
}
