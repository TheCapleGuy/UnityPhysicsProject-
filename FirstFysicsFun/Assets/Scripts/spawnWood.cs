using UnityEngine;
using System.Collections;

public class spawnWood : MonoBehaviour {
	public GameObject g;
	// Use this for initialization
	void Start () {
		//Instantiate (g, this.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	public void Spawn() {
		Instantiate (g, new Vector3(0,-1,0), Quaternion.identity);

	}
}
