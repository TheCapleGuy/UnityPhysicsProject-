using UnityEngine;
using System.Collections;

public class build : MonoBehaviour {
    static bool IsMouseOver(Rect button, Rect window)
    {
        //return Event.current.type == EventType.Repaint && GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition);
        
        bool b = false;
        //but it seems to need +1 on y axis for no reason (?) - presumed header issue
        Rect check = new Rect(button.x + window.x, button.y + window.y + 1, button.width, button.height);
        b = check.Contains(Event.current.mousePosition);
        return b;
    }

    void FixedUpdate()
    {
        //if (IsMouseOver() == true)
        //{
        //    Debug.Log("works");
        //}
        
    }
    
}
