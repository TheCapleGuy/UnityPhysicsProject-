using UnityEngine;
using System.Collections;

public class SpawningMiniProjectiles : MonoBehaviour {

    //timer
    private float spawnTimer;
    private float timePassed;

    //# of mini projectiles and frequency to spawn
    public float numMiniProjectiles;
    public float timesSpawned;
	
    // Use this for initialization
	void Start ()
    {
        spawnTimer = 1.5f;
        timePassed = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timePassed += Time.deltaTime;
        if (timePassed > spawnTimer)
        {
            //set timer to 0
            for (int i = 0; i < numMiniProjectiles; i++)
            {
                //spawn prefab
                //set all individual prefabs trojectory in 3 dif directions
            }
            return;
        }

    }

}
