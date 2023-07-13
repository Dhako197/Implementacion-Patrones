using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFactory : MonoBehaviour
{
   
    [SerializeField] private PowerUp _powerUpGreen;
    [SerializeField] private PowerUp _powerUpRed;
    [SerializeField] private PowerUp _powerUpFlower;

    [SerializeField] private Transform _spawnPoint;

    public PowerUp Create(string type)
    {     

        switch (type)
        {
            case "Green":
                return Instantiate(_powerUpGreen, _spawnPoint, false);

            case "Red":
                return Instantiate(_powerUpRed,_spawnPoint);

            case "Flower":
                return Instantiate(_powerUpFlower, _spawnPoint);
            default:
                throw null;


        }

    }

}
