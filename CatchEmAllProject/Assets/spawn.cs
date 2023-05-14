using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Vector3 center, size;
    public GameObject o;
    public GameObject p;
    Rigidbody rb;
    private float time = 0.0f;
    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            time = 0.0f;
            SpawnObject();
        }
    }
    public void SpawnObject()
    {
        Vector3 pos = center + new Vector3(Random.Range(-30,30), transform.position.y, Random.Range(-20, 20));
        GameObject c = Instantiate(o, pos, Quaternion.Euler(-90,0,0)) as GameObject;
        //GameObject particle = Instantiate(p, pos, Quaternion.Euler(-90, 0, 0)) as GameObject;
        rb = c.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * 90);
        //rb = particle.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.down * 90);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
