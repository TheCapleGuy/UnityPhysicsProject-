using UnityEngine;
using System.Collections;

public class SpawnProjectiles : MonoBehaviour {

    public int totalNumberOfProjectiles;
    private int numberOfProjectilesSpawned;
    public Object prefab;
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
                Debug.Log("Spawn!: " + prefab.name);
                Instantiate(prefab, transform.position, Quaternion.identity);
            }
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
	}
}
