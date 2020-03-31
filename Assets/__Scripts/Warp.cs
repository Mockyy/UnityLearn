using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Screen.width)
        {
            transform.position.Set(0, transform.position.y, transform.position.z);
        }

        if (transform.position.y > Screen.height)
        {
            transform.position.Set(transform.position.x, 0, transform.position.z);
        }
    }
}
