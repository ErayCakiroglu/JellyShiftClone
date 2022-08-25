using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float lerpValue;

    void Start()
    {
        offset = transform.position - target.position;
    }

    /*Aldığı transform değerini takip etmesini sağlayan kamera takip metodu.*/
    void LateUpdate()
    {
        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
