using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Traps : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.GameOver();
            Destroy(other.gameObject);
        }
    } 
}
