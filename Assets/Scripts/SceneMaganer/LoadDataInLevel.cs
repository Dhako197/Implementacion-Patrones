using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataInLevel : MonoBehaviour
{
    private void Start()
    {
        CharacterValues.Instance.Points = Repository.Instance.Points;
        CharacterValues.Instance.Coins = Repository.Instance.Coins;
    }
}
