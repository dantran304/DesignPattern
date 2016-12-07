using UnityEngine;
using System.Collections;
using System;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class Box : Observer {

    GameObject boxObj;
    BoxEvents boxEvent;


    public Box(GameObject boxObj, BoxEvents boxEvent)
    {
        this.boxObj = boxObj;
        this.boxEvent = boxEvent;
    }

    public override void OnNotify()
    {
        float jumpforce = boxEvent.GetJumpForce();
        Debug.Log(" " + this + jumpforce);
        Jump(boxEvent.GetJumpForce());
    }

    void Jump(float jumpForce)
    {
        if (boxObj.transform.position.y < 0.55f)
        {
            boxObj.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
