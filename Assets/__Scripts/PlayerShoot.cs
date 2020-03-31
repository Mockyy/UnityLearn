using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition +
            Vector3.back * Camera.main.transform.position.z);

        transform.LookAt(mousePos);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject cloneBullet = Instantiate(bullet, transform.position, transform.rotation);
        cloneBullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
        Destroy(cloneBullet, 2f);
    }
}
