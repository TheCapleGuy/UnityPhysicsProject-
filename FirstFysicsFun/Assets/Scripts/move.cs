using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float jumpPow;
    public bool horizLock;
    public bool vertLock;
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        bool r, u, d, l, sp;
        r = Input.GetKey(KeyCode.RightArrow);
        l = Input.GetKey(KeyCode.LeftArrow);
        u = Input.GetKey(KeyCode.UpArrow);
        d = Input.GetKey(KeyCode.DownArrow);
        sp = Input.GetKeyDown(KeyCode.Space);

        if (sp) v += jumpPow;
        if (r || l || u || d || sp)
        {
            if (horizLock) h = 0;
            if (vertLock) v = 0;

            rb.velocity = new Vector3(h, v, 0) * speed;
        }
        else rb.velocity = new Vector3(0, 0, 0);
    }

}
