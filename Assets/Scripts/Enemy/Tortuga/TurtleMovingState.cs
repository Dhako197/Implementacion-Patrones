using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovingState : TurtleBaseState
{
    [SerializeField] private float _speed = 5f;
    private Vector2 _direction = Vector2.right;
    private bool _toRight = true;

    public override void EnterState(TurtleStateManager turtle)
    {
    }

    public override void OncollisionEnter2D(TurtleStateManager turtle, Collision2D collision)
    {
        bool _obtacle = collision.gameObject.CompareTag("Obstacle");
        bool _enemy = collision.gameObject.CompareTag("Enemy");
        bool _player = collision.gameObject.CompareTag("Player");
        bool _enemy2 = collision.gameObject.CompareTag("Turtle");

        if (_obtacle || _enemy || _enemy2)
            ChangeDirection();
        else if (_player)
        {
            CharacterValues.Instance.TakeDamage();
            ChangeDirection();
        }

    }

    public override void UpdateState(TurtleStateManager turtle)
    {
        Vector2 _displacement = _direction * _speed * Time.deltaTime;
        transform.Translate(_displacement);
    }
    private void ChangeDirection()
    {
        if (_toRight)
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
}
