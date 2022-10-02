using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOpt : MonoBehaviour
{
    MainCubeOptions opt;
    GameObject Place;
    
    void Start()
    {
        opt = GameObject.FindGameObjectWithTag("opt").GetComponent<MainCubeOptions>();
        Place = GameObject.FindGameObjectWithTag("place");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("cube"))
        {
            opt.CubeCreate();
            opt.Cubealign();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("tuzak"))
        {
            transform.SetParent(Place.transform);
            opt.cubeRemove();
        }
    }
}
