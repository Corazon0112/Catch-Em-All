using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class fade : MonoBehaviour
{
    Timer myTimer;
    public ParticleSystem emit;
    // Start is called before the first frame update
    void Start()
    {
        myTimer = new Timer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        emit.transform.parent = null;
        Destroy(gameObject);
    }
}
