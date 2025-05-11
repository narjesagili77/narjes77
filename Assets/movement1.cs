
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.forward * 5f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.right * 5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.left * 5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.back * 5f);
        }
    }

}
