using UnityEngine;
using System.Collections;

public class moveBckrnd : MonoBehaviour {
    public int bounds = 3;
    public float speed = .15f;
    public float startPos = 0;

    void Start()
    {

        //r = GetComponent<Renderer>();
    }

	void Update () {
        //Vector2 offset = new Vector2(Time.time * speed, 0);
        //r.material.SetTextureOffset("_MainTex", offset);
        if (transform.position.x > bounds || transform.position.x < -bounds) speed *= -1;
        startPos += speed * Time.deltaTime;
        transform.position = new Vector3(startPos, transform.position.y, 8);



    }
}