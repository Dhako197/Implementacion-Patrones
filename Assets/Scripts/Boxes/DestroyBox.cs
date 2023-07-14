using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] private GameObject _fatherGameObject;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterValues _characterValues = collision.gameObject.GetComponent<CharacterValues>();
            bool _isMedium= _characterValues._actualState == CharacterValues._state.medium;
            bool _isFire = _characterValues._actualState == CharacterValues._state.fire;

            if (_isFire || _isMedium)
            {
                Destroy(_fatherGameObject);
            }
                


        }
    }
}
