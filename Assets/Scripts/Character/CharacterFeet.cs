using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFeet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GetInvulnerable();
            Destroy(collision.gameObject);
            
        }
        else if(collision.gameObject.CompareTag("Turtle"))
        {
            GetInvulnerable();
            TurtleStateManager _turtleStateManager = collision.gameObject.GetComponent<TurtleStateManager>();
            _turtleStateManager.SwitchState(_turtleStateManager._diedState);
        }            
    }

    private void GetInvulnerable()
    {
        CharacterValues.Instance.Invulnerable();
    }
}
