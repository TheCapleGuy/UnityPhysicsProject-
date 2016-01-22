using UnityEngine;
using System.Collections;

public class ImplosionDeath : MonoBehaviour {

    public float lifeSpan;
	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        Destroy(gameObject, lifeSpan);
	}
}
