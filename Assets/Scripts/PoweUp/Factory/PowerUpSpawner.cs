using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private PowerUpFactory _powerUpFactory;
    [SerializeField] private Color _color;
    private SpriteRenderer _spriteRenderer;
    private bool _canInteract = true;

    private CharacterValues _characterValues;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _canInteract)
        {
            _characterValues = collision.gameObject.GetComponent<CharacterValues>();

            if (_characterValues._actualState == CharacterValues._state.little)
            {
                _powerUpFactory.Create("Green");
            }
            else
                _powerUpFactory.Create("Flower");
            _spriteRenderer.color = _color;
            _canInteract = false;
        }
    }
   

}
