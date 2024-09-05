using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variables
    [SerializeField]
    private int _fruits;
    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _jumpForce;
    private bool _resetJumpNeeded = false;
    private bool _isGrounded = false;
    [SerializeField]
    private Animator _GameOver_Animator;

    // Handles
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private LayerMask _layerMask;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    void Update()
    {
        Movement();   
    }

    private void Movement()
    {
        float move = Input.GetAxis("Horizontal");
        Flip(move);
        _isGrounded = IsGrounded();
        _rigidbody2D.velocity = new Vector2(move * _speed,_rigidbody2D.velocity.y);
        RunAnim(move);

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded() == true)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce);
            StartCoroutine(resetJumpNeeded());
            _animator.SetBool("Jumping", true);
        }
    }
    private bool IsGrounded()
    {
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, _layerMask);
        Debug.DrawRay(transform.position, Vector2.down, Color.yellow);
        if(Hit.collider != null)
        {
           // Debug.Log("Grounded");
            if(_resetJumpNeeded == false)
            {
                _animator.SetBool("Jumping", false);
                return true;
            }   
        }
        return false;
    }

    IEnumerator resetJumpNeeded()
    {
        _resetJumpNeeded = true;
        yield return new WaitForSeconds(1.0f);
        _resetJumpNeeded = false;
    }

    public void AddFruits(int Fruits)
    {
        _fruits += Fruits;
        UI_Manager.Instance.CurrentFruitCount(Fruits);
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
    public void GameOver()
    {
        _GameOver_Animator.SetBool("GameOver", true);
        Time.timeScale = 0.0f;
    }
}
