using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repository : MonoBehaviour
{
    private float _coins;
    private float _points;

    public static Repository Instance { get; private set; }
    public float Coins { get => _coins; }
    public float Points { get => _points;}

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

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
}
