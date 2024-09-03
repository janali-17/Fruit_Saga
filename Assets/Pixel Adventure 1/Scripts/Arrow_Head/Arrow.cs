using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private int _speed = 8;
    [SerializeField]
    Animator _animator;

    void Update()
    {
        ShootArrow();
    }

    void ShootArrow()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);

        StartCoroutine(ArrowDestroy());
            //Debug.Log("Destroy the arrow");
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.GameOver();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
    IEnumerator ArrowDestroy()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }
}
