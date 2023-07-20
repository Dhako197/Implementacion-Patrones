using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleStateManager : MonoBehaviour
{
    TurtleBaseState _currentState;
    public TurtleMovingState _movingState = new TurtleMovingState();
    public TurtleDiedState _diedState = new TurtleDiedState();

    private void Start()
    {
        _currentState = _movingState;

        _currentState.EnterState(this);
    }

    private void Update()
    {
        _currentState.UpdateState(this);
    }

    public void SwitchState(TurtleBaseState turtleState)
    {
        _currentState = turtleState;
        turtleState.EnterState(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _currentState.OncollisionEnter2D(this, collision);
    }
}
