using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    int _friuts = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
          //  Debug.Log("Fruit trigger");
          player.AddFruits(_friuts);
            Destroy(this.gameObject);
        }
    }
}
