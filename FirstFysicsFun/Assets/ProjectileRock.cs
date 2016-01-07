using UnityEngine;
using System.Collections;

public class ProjectileRock : MonoBehaviour
{
    private Vector3 dir;
    private Vector2 intensity;
    public Rigidbody2D rigidbody;

	// Use this for initialization
	void Start ()
    {


        dir = new Vector3(10, Random.Range(12, 5), 1);
        intensity = new Vector2(1.1f, 1.1f);
        rigidbody.velocity = new Vector3((dir.x * intensity.x), (dir.y * intensity.y), dir.z);
	}
	
	// Update is called once per frame
	void Update ()
    {
         Destroy(gameObject, 4);
    }
}
