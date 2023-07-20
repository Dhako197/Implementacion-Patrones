using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleDiedState : TurtleBaseState
{
    [SerializeField] private Color _color;
    [SerializeField] private float _enemyPoints = 100f;
    public override void EnterState(TurtleStateManager turtle)
    {
        CharacterValues.Instance.GetPoints(_enemyPoints);
        SpriteRenderer _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _spriteRenderer.color = _color;
    }

    public override void OncollisionEnter2D(TurtleStateManager turtle , Collision2D collision)
    {
        
    }

    public override void UpdateState(TurtleStateManager turtle)
    {
        
    }
}
