using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterValues : MonoBehaviour
{
    [SerializeField] private CheckPointManager _checkPointManager;
    private SpriteRenderer _spriteRenderer;

    private float _points= 0;
    private float _coins = 0;
    private float _time = 400;
    private float _lives = 3;

    public  enum _state { little, medium, fire, star }
    public _state _actualState = _state.little;

    private bool _isInvulnerable = false;

    public float Points { get => _points; set => _points = value; }
    public float Coins { get => _coins; set => _coins = value; }
    public float Lives { get => _lives; set => _lives = value; }
  

    private void Start()
    {
        _checkPointManager = gameObject.GetComponent<CheckPointManager>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && _actualState != _state.star && !_isInvulnerable)
            TakeDamage();
    }

    private void TakeDamage()
    {
        switch (_actualState)
        {
            case _state.little:
                Restart();
                break;

            case _state.medium:
                _actualState = _state.little;
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;

            case _state.fire:
                _actualState = _state.medium;
                _spriteRenderer.color = new Color(255f, 255f, 255f);
                break;
             
        }
      
    }

    
    private void Restart()
    {
        _checkPointManager.CharacterRespawn();
    }

    private void Invulnerable()
    {
        _isInvulnerable = true;
        Invoke("BackToVulnerable", 0.5f);
    }

    private void BackToVulnerable()
    {
        _isInvulnerable = false;
    }
}
