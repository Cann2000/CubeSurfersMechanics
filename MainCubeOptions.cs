using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeOptions : MonoBehaviour
{

    // *!!!* INSIDE THE MAIN CUBE *!!!*

    // PREFAB MUST BE RIGIDBODY IN CUBE


    public List<GameObject> cubes;

    public GameObject Cube;

    public float speed;



    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(move, 0, 0);
    }

    public void CubeCreate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.50f, transform.position.z);

        GameObject CubeClone = Instantiate(Cube, transform);
        CubeClone.AddComponent<CubeOpt>();
        cubes.Add(CubeClone);
        Cubealign();
    }

    public void Cubealign()
    {
        for (int i = 1  ; i < cubes.Count; i++)
        {
            cubePos(cubes[i].transform, i * -1);
        }
    }

    public void cubeRemove()
    {
        for (int i = cubes.Count - 1; i < cubes.Count; i++)
        {
            cubes.RemoveAt(i);
        }
    }

    void cubePos(Transform Object, int Ypos)
    {
        Vector3 pos = Vector3.zero;

        pos.x = 0;
        pos.y = Ypos;
        pos.z = 0;

        Object.localPosition = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("cube"))
        {
            CubeCreate();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("cube"))
        {
            CubeCreate();
        }
    }
}
