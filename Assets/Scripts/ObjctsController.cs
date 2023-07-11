using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjctsController : MonoBehaviour
{
    [SerializeField] private ObjectsMovement _objectsMovement;
    [SerializeField] private ICommand _currentCommand;

    private void Start()
    {
        _objectsMovement = GetComponent<ObjectsMovement>();
        _currentCommand = new MoveLeftCommand(_objectsMovement);
        _currentCommand.Execute();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obtacle"))
        {
            if (_currentCommand is MoveRightCommand)
            {
                _currentCommand = new MoveLeftCommand(_objectsMovement);
            }
            else if (_currentCommand is MoveLeftCommand)
            {
                _currentCommand = new MoveRightCommand(_objectsMovement);
            }

            _currentCommand.Execute();
        }
    }
}
