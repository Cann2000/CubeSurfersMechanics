using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform MainCharacter;
    public float followSpeed;

    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, MainCharacter.position, followSpeed) + offset;
    }
}
