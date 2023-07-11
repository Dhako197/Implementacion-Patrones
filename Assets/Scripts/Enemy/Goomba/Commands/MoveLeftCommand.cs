using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand: ICommand
{
    private ObjectsMovement _objectsMovement;

    public MoveLeftCommand(ObjectsMovement _objectsMovement)
    {
        this._objectsMovement = _objectsMovement;
    }

    public void Execute()
    {
        _objectsMovement.MoveLeft();
    }
}
