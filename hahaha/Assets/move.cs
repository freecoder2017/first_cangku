using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody yw = null;
    // Use this for initialization
    void Start()
    {
        yw = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        yw.AddForce(new Vector3(h, 0, v) * 10);
    }
}
