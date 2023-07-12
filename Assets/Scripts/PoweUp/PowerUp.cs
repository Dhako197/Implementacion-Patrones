using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{  
    [SerializeField] private string _type;
    protected float _score = 100;

    public string Type { get => _type;}

    public abstract void OnCollisionEnter2D(Collision2D collision);

    public abstract void AlreadyHave();
    
}
