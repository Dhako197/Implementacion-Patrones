using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataInLevel : MonoBehaviour
{
    private void Start()
    {
        CharacterValues.Instance.Points = Repository.Instance.LoadPoints();
        CharacterValues.Instance.Coins = Repository.Instance.LoadCoins();
    }
}
