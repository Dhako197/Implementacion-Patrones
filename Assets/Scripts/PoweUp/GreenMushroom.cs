using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMushroom : PowerUp
{
    [SerializeField] private CharacterValues _characterValues;

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _characterValues = collision.gameObject.GetComponent<CharacterValues>();
            if (_characterValues._actualState != CharacterValues._state.medium)
            {
                collision.gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                _characterValues._actualState = CharacterValues._state.medium;
                _characterValues.Points += _score;
            }
            else AlreadyHave();
           
            Destroy(gameObject);
        }
    }

    public override void AlreadyHave()
    { 
        _characterValues.Points += (_score * 2);
    }
}

