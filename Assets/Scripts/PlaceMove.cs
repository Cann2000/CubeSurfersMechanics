using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMove : MonoBehaviour
{
    public float placeMove;

    void Update()
    {
        transform.Translate(0, 0, -placeMove * Time.deltaTime);
    }
}
