using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBox : MonoBehaviour
{
    [SerializeField] private Color _usedColor;
    [SerializeField] private int _coindsCount;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (_coindsCount <= 0)
            _spriteRenderer.color = _usedColor;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _coindsCount>0)
        {
            CharacterValues characterValues = collision.gameObject.GetComponent<CharacterValues>();
            characterValues.Coins++;
            _coindsCount--;
        }
    }


}
