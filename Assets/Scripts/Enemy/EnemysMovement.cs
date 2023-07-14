using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Vector2 _direction = Vector2.right;
    private bool _toRight = true;
    void Update()
    {
        Vector2 _displacement = _direction * _speed * Time.deltaTime;
        transform.Translate(_displacement);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool _obtacle = collision.gameObject.CompareTag("Obstacle");
        bool _enemy = collision.gameObject.CompareTag("Enemy");

        if ((_obtacle || _enemy) && _toRight)
        {
            _direction = Vector2.left;
            _toRight = false;
        }
        else
        {
            _direction = Vector2.right;
            _toRight = true;
        }

    }

    public void Died()
    {
        Destroy(gameObject);
    }
}
