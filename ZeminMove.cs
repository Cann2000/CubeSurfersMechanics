using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminMove : MonoBehaviour
{
    public float zeminMove;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, -zeminMove * Time.deltaTime);
    }
}
