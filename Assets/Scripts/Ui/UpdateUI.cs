using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] private CharacterValues _characterValues;
    [SerializeField] private TMP_Text _textMeshPoints;
    [SerializeField] private TMP_Text _textMeshCoins;
    [SerializeField] private TMP_Text _textMeshTime;

    private void Start()
    {
        _characterValues.OnPointsChanged += UpdatePointsUI;
        _characterValues.OnCoinsChanged += UpdateCoinsUI;
        _characterValues.OnTimeChanged += UpdateTimeUI;
    }

    private void UpdatePointsUI(float _points)
    {
        _textMeshPoints.text = _points.ToString();
    }
    private void UpdateCoinsUI(float _coins)
    {
        _textMeshCoins.text = "x " +_coins.ToString();
    }

    private void UpdateTimeUI(float _time)
    {
        _textMeshTime.text = _time.ToString();
    }
}
