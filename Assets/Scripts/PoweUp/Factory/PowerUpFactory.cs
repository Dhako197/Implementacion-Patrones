using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFactory : MonoBehaviour
{
    [SerializeField] private PowerUp[] _powerUps;
    private Dictionary<string, PowerUp> _powerUpType;

    private void Awake()
    {
        _powerUpType = new Dictionary<string, PowerUp>();
        foreach(var powerup in _powerUps)
        {
            _powerUpType.Add(powerup.Type, powerup);
        }       

    }

    public PowerUp Create(string type)
    {
        if(!_powerUpType.TryGetValue(type, out var powerUp))
        {
            return null;
        }
        return powerUp;
    }
}
