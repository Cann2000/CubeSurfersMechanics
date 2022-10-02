using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform MainCharacter;
    public float followSpeed;

    public Vector3 offset;


    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, MainCharacter.position, followSpeed) + offset;

    }
}
