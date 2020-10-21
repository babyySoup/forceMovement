using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCube : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {

    }

    private void OnMouseDown()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
}