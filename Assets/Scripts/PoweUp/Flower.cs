using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : PowerUp
{
    [SerializeField] private CharacterValues _characterValues;
    private SpriteRenderer _spriteRenderer;

   
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _characterValues = collision.gameObject.GetComponent<CharacterValues>();

            if (_characterValues._actualState != CharacterValues._state.fire)
            {
                _characterValues._actualState = CharacterValues._state.fire;
                _spriteRenderer = _characterValues.GetComponent<SpriteRenderer>();
                _spriteRenderer.color = new Color(252f, 0, 0);
                _characterValues.Points += _score;
            }
            else AlreadyHave();

            Destroy(gameObject);
        }
    }
    public override void AlreadyHave()
    {
        _characterValues.Points += (_score*2);
    }
}
