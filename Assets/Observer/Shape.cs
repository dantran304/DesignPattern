using UnityEngine;
using System.Collections;
using System;

public class Shape : Observer {

    public float jumpForce;

    public override void OnNotify()
    {
        Debug.Log("jump force = " + jumpForce);
        Jump(jumpForce);
    }

    void Jump(float jumpForce)
    {
        if (gameObject.transform.position.y < 0.55f)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
