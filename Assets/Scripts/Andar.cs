using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody cubo;
    void Start()
    {
        cubo = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            cubo.AddRelativeForce(new Vector3(0, 0, 25), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubo.AddRelativeForce(new Vector3(0, 0, -25), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
    }
}
