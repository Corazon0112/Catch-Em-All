using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x < 30)
        {
            gameObject.transform.Translate(.5f, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -30)
        {
            gameObject.transform.Translate(-.5f, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow) && gameObject.transform.position.z < 397+20)
        {
            gameObject.transform.Translate(0, 0, .5f, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow) && gameObject.transform.position.z > 397-20)
        {
            gameObject.transform.Translate(0, 0, -.5f, Space.Self);
        }
    }
}
