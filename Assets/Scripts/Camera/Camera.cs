using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed = 0.5f;
    private Vector3 offset; 

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        float targetX = target.position.x + offset.x; 
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
