using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField, Range(0f, 50f)] private float JumpStrength = 1f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float RotateSpeed = 1f;

    void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping");
            rb.velocity = new Vector3(0f, JumpStrength, 0f);
        }



        if (rb.velocity.y < 0f)
        {
            transform.LookAt(transform.position + Vector3.forward * 2f + new Vector3(0f, -RotateSpeed, 0f)*Mathf.Abs(rb.velocity.y*0.1f));
        } else {
            transform.LookAt(transform.position + Vector3.forward * 2f + new Vector3(0f, RotateSpeed, 0f)*Mathf.Abs(rb.velocity.y*0.1f));
        }
    }
}
