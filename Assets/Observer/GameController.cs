using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public Observer boxObj;
    public Observer sphereObj;

    ObserversDispatcher observerDispatcher = new ObserversDispatcher();

    void Start()
    {
        observerDispatcher.AddObserver(boxObj);
        observerDispatcher.AddObserver(sphereObj);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Subject phat su kien Notify");
            observerDispatcher.Notify();
        }
    }
}
