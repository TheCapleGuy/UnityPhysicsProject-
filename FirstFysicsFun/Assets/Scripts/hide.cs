using UnityEngine;
using System.Collections;

public class hide : MonoBehaviour {

    public Renderer r;
	// Use this for initialization
	void Start () {
        r.enabled = false;
	}
}
