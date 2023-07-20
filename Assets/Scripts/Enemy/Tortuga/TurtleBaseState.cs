using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurtleBaseState : MonoBehaviour
{
    public abstract void EnterState(TurtleStateManager turtle);
    public abstract void UpdateState(TurtleStateManager turtle);
    public abstract void OncollisionEnter2D(TurtleStateManager turtle, Collision2D collision);

}
