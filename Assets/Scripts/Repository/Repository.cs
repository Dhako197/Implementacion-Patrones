using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repository : MonoBehaviour
{
    private float _coins;
    private float _points;

    public static Repository Instance { get; private set; }


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    public void SaveData(float coins, float points)
    {
        _coins = coins;
        _points = points;
    }

    public float LoadCoins()
    {
       return _coins;
    }
    public float LoadPoints()
    {
        return _points;
    }


}
