using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointCommand : ICommand
{
    [SerializeField] private Transform _characterActualPosition;
    [SerializeField] private Vector2 _checkPointPosition;

    public CheckPointCommand (Transform CharacterActualPosition, Vector2 CheckPointPosition)
    {
        this._characterActualPosition = CharacterActualPosition;
        this._checkPointPosition = CheckPointPosition;
    }

    public void Execute()
    {
        _characterActualPosition.position = _checkPointPosition;
    }
}
