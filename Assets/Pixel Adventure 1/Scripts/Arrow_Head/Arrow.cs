using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private int _speed = 8;
    

    void Start()
    {
        
    }

    void Update()
    {
        ShootArrow();
    }

    void ShootArrow()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        if (transform.position.x >= 29)
        {
            //Debug.Log("Destroy the arrow");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
