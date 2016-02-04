using UnityEngine;
using System.Collections;

public class SpawnProjectiles : MonoBehaviour {

    public int totalNumberOfProjectiles;
    private int numberOfProjectilesSpawned;
    //public Object prefab;
    public GameObject g, go, arrows, winTxt, loseTxt;
    public float projectileSize;

    private float spawnDelay;
    private float time;

    IEnumerator CheckLvlBeat(GameObject []pList)
    {
        yield return new WaitForSeconds(3);
        bool allAlive = true;
        foreach (GameObject g in pList)
        {
            // check if hp <= 0
            targetDmg tScript = g.GetComponent<targetDmg>();
            if (tScript.hp <= 0)
            {
                allAlive = false;
            }
        }
        if (allAlive == false)
        {
            // start level again
            loseTxt.SetActive(true);
            yield return new WaitForSeconds(2);
            Application.LoadLevel("level 1");
        }
        else
        {
            winTxt.SetActive(true);
            yield return new WaitForSeconds(2);
            Application.LoadLevel("main menu");
        }
    }

	// Use this for initialization
	void Start ()
    {
        time = 0;
        spawnDelay = .6f;
        //arrows = Instantiate(arrows, arrows.transform.position, Quaternion.identity) as GameObject;
        arrows.SetActive(false);
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
                go.transform.localScale = new Vector3(projectileSize, projectileSize, projectileSize);
                arrows.SetActive(true);
            }
            // after all are spawned
            else
            {
                // find all pigs
                GameObject []pigList = GameObject.FindGameObjectsWithTag("pig");

                // wait 3 sec then start function
                StartCoroutine(CheckLvlBeat(pigList));
                
                arrows.SetActive(false);
            }
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
	}
}
