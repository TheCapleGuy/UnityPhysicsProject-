using UnityEngine;
using System.Collections;

public class SpawningMiniProjectiles : MonoBehaviour {

    //timer
    private float spawnTimer;
    private float timePassed;
    private Vector2 spawnLocation;

    //for added velocity to this projectile only
    private Vector2 intensity;
    private Rigidbody2D rigidbody;

    //# of mini projectiles and frequency to spawn
    public float numMiniProjectiles;
    public float timesSpawned;
    public Object prefab;
    public Transform tform;

    // Use this for initialization
    void Start ()
    {
        //only supplementing projectileLaunches start addforce
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(new Vector2(5,2), ForceMode2D.Impulse);

        spawnTimer = .8f;
        timePassed = 0;
        timesSpawned = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnLocation = new Vector2(transform.position.x - 1, transform.position.y - 1);
        timePassed += Time.deltaTime;
        if (timePassed > spawnTimer)
        {
            //decrease time inbetween shots
            spawnTimer -= .3f;
            //set timer to 0
            timePassed = 0;
            if (timesSpawned < 4)
            {
                timesSpawned++;
                for (int i = 0; i < numMiniProjectiles; i++)
                {

                    //spawn prefab
                    Instantiate(prefab, spawnLocation, Quaternion.identity);

                    //set all individual prefabs trojectory in 3 dif directions
                    spawnLocation.x++;
                    

                }
            }
            else
            { // has shot all projectiles
                //destroy after a half second
                Destroy(gameObject, .5f);
            }
        }
    }
}
