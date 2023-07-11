using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    private ObjectsMovement _objectsMovement;

    public MoveRightCommand(ObjectsMovement _objectsMovement)
    {
        this._objectsMovement = _objectsMovement;
    }

    public void Execute()
    {
        _objectsMovement.MoveRight();
    }
}
