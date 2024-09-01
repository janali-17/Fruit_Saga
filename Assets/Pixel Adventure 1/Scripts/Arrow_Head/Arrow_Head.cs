using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Head : MonoBehaviour
{
    [SerializeField]
    private float _fireRate = 3.0f;
    [SerializeField]
    private float _canFire = -1;
    [SerializeField]
    private GameObject _arrowPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_canFire < Time.time)
        {
            _fireRate = Random.Range(3.0f, 6.0f);
            _canFire = Time.time + _fireRate;
            Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0, 0, -90.0f));

        }
    }
}
