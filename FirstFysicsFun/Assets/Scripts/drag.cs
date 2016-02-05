using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {

    public int distance = 12;
    private Camera cam;
    private bool rotating, wasDragging, isDragging = false;
    private Quaternion rotation;

    void Start()
    {
        cam = FindObjectOfType<Camera>();
    }

    private Vector3 mousePos, mouseLocInWorldSpace;
    public void OnMouseDrag()
    {
        if(Time.timeScale == 0)
        {
            isDragging = true;
            this.gameObject.transform.position = mouseLocInWorldSpace;
        }
    }

    //public void EndDrag()
    //{ 
    //    rotating = true;
    //    Debug.Log(rotating);
    //}

    public void RotateObj()
    {

        if (rotating) //selectedObj.transform.LookAt(mouseLocInWorldSpace, transform.up);
        {
            this.gameObject.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
        }

        if (Input.GetMouseButtonDown(0))
        {
            rotating = false;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            isDragging = false;

        if (wasDragging && !isDragging)
            rotating = true;

        if(rotating)
            rotation = Quaternion.LookRotation(
                                /*Input.mousePosition - selectedObj.transform.position,*/
                                mouseLocInWorldSpace - this.gameObject.transform.position,
                                this.gameObject.transform.TransformDirection(Vector3.up));

        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        mouseLocInWorldSpace = cam.ScreenToWorldPoint(mousePos);

        RotateObj();
    }

    void LateUpdate()
    {
        wasDragging = isDragging;
    }
    //void OnMouseDrag()
    //   {
    //       Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
    //       Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
    //       this.transform.position = objPos;
    //   }
}
