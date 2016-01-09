using UnityEngine;
using System.Collections;

public class ProjectileLaunch : MonoBehaviour
{
    private Vector2 dir;
    private Vector2 intensity;
    public Rigidbody2D rigidbody;

	// Use this for initialization
	void Start ()
    {
        //this can be done better....
        dir = new Vector3(10, Random.Range(14, 7));
        intensity = new Vector2(1.1f, 1.1f);
        dir = new Vector2((dir.x * intensity.x), (dir.y * intensity.y));

        //change to addForce
        //rigidbody.velocity = new Vector3(dir.x, dir.y, 1);
        rigidbody.AddForce(dir, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(transform.position.x > 30)
         Destroy(gameObject);
    }
}
