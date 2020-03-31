using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;

    [SerializeField]
    private float shipSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float vertical = CrossPlatformInputManager.GetAxis("Vertical");

        direction = new Vector3(horizontal, vertical, 0);

        if (direction.magnitude > 1)
        {
            direction.Normalize();
        }

        rb.velocity = direction * shipSpeed;
    }

    private void FixedUpdate()
    {
       // rb.MovePosition(rb.transform.position + direction * shipSpeed * Time.deltaTime);
    }
}
