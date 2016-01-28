using UnityEngine;
using System.Collections;

public class SpawnProjectiles : MonoBehaviour {

    public int totalNumberOfProjectiles;
    private int numberOfProjectilesSpawned;
    //public Object prefab;
    public GameObject g, go;
    public float projectileSize;

    private float spawnDelay;
    private float time;

	// Use this for initialization
	void Start ()
    {
        time = 0;
        spawnDelay = .6f;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (time > spawnDelay)
        {
            //spawn
            if (numberOfProjectilesSpawned < totalNumberOfProjectiles)
            {
                numberOfProjectilesSpawned++;
                //Debug.Log("Spawn!: " + prefab.name);
                go = Instantiate(g, transform.position, Quaternion.identity) as GameObject;
                go.transform.localScale *= projectileSize;
            }
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
	}
}
