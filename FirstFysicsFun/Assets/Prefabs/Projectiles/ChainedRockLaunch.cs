using UnityEngine;
using System.Collections;

public class ChainedRockLaunch : MonoBehaviour {
    //script for chainedRock prefab
    //this prefab needs extra velocity on spawn
    //add random
    public Vector2 force;
    public Rigidbody2D rbody;
    //for making the projectiles not land in the same spot all the time
    public float randRange;
    private Vector2 rand;

	// Use this for initialization
	void Start ()
    {
        rand = new Vector2(Random.Range(-randRange, randRange), Random.Range(-randRange, randRange));
        rbody.AddForce(force + rand, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
