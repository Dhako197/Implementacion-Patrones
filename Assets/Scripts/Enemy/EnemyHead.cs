using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHead : MonoBehaviour
{
    private EnemysMovement _enemysMovement;
    private CharacterMovement _characterMovement;

    private void Start()
    {
        _enemysMovement = GetComponentInParent<EnemysMovement>();
    }


    public void Destroy()
    {
        _enemysMovement.Died();
    }
}
