using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private ICommand _checkPointCommand;
    [SerializeField] private Vector2 _lastCheckpoint;

    private void Start()
    {
        _checkPointCommand = null;
        _lastCheckpoint = transform.position;
    }

    public void SetCheckpoint(Vector2 _checkpointPosition)
    {
        _checkPointCommand = new CheckPointCommand(transform, _checkpointPosition);
    }

    public void RestoreCheckpoint()
    {
        if (_checkPointCommand != null)
            _checkPointCommand.Execute();
    }

    public void CharacterRespawn()
    {
        RestoreCheckpoint();
    }
}
