using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {

    public int distance = 12;

	void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        this.transform.position = objPos;
    }
}
