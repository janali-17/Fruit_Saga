using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variables
    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _jumpForce;

    // Handles
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        Movement();   
    }

    private void Movement()
    {
        float move = Input.GetAxis("Horizontal");
        Flip(move);
        _rigidbody2D.velocity = new Vector2(move * _speed,_rigidbody2D.velocity.y);
        RunAnim(move);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce);
        }
    }

    private void RunAnim(float move)
    {
        _animator.SetFloat("Run",Mathf.Abs(move));
    }
    private void Flip(float move)
    {
        if(move > 0)
        {
            _spriteRenderer.flipX = false;
        }
        else if (move < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }
}
