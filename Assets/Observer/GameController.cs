using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject sphereObj;
    public GameObject boxObj1;
    public GameObject boxObj2;
    public GameObject boxObj3;


    Subject subject = new Subject();

    void Start()
    {
        //khởi tạo các đối tượng box và truyền hành vi tương ứng
        Box box1 = new Box(boxObj1, new JumpLittle());
        Box box2 = new Box(boxObj2, new JumpMedium());
        Box box3 = new Box(boxObj3, new JumpHigh());

        subject.AddObserver(box1);
        subject.AddObserver(box2);
        subject.AddObserver(box3);
    }

    void Update()
    {
        //if ((sphereObj.transform.position).magnitude < 0.5f)
        //{
        //    Debug.Log("Subject phat su kien Notify");
        //    subject.Notify();
        //}
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Subject phat su kien Notify");
            subject.Notify();
        }
    }
}
