using UnityEngine;
using System.Collections;

public class Implosion : MonoBehaviour {

    public Object prefab;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Implosion here");
        Instantiate(prefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

	// Update is called once per frame
	void Update ()
    {
	    
	}
}
