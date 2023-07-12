using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMushroom :PowerUp
{
    [SerializeField] private CharacterValues _characterValues;

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _characterValues = collision.gameObject.GetComponent<CharacterValues>();
            _characterValues.Lives++;

            Destroy(gameObject);
        }
    }

    public override void AlreadyHave()
    {
        return;
    }
}
