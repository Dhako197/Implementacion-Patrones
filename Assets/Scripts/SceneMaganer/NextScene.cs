using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Repository.Instance.SaveData(CharacterValues.Instance.Coins, CharacterValues.Instance.Points);
            SceneManager.LoadScene("Nivel 2");

        }
    }
}
