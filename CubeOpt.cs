using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOpt : MonoBehaviour
{
    Options opt;
    GameObject zemin;
    
    void Start()
    {
        opt = GameObject.FindGameObjectWithTag("opt").GetComponent<Options>();
        zemin = GameObject.FindGameObjectWithTag("zemin");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("cube"))
        {
            opt.CubeYarat();
            opt.diz();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("tuzak"))
        {
            transform.SetParent(zemin.transform);
            opt.cubeRemove();
        }
    }
}
