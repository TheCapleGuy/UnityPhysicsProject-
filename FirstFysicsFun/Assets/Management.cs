using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Management : MonoBehaviour
{
    //public List<GameObject> pigs;
    public List<GameObject> projectileSpawners;
    //public GameObject arrows, rndTxt, loseTxt;
    private List<int> spawnedProjectiles;
    public int round;

    public GameObject spawnObj;
    // Use this for initialization
    void Start ()
    {
        spawnedProjectiles = new List<int>() {0, 0, 0, 0};
        spawnObj = GameObject.FindWithTag("SpawnObj");
        //might not be necessary
        for (int i = 1; i < projectileSpawners.Count; i++)
            projectileSpawners[i].SetActive(false);

        //setting number of projectiles to be spawned at start of round
        //rock projectile
        spawnedProjectiles[0] = 6;
        //chained rock
        spawnedProjectiles[1] = 0;
        //explosion bomb
        spawnedProjectiles[2] = 0;
        //implosion bomb
        spawnedProjectiles[3] = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (round < 4 && projectileSpawners.Count > 1)
            projectileSpawners[round].SetActive(true);

        if (projectileSpawners.Count > 1)
        {
            if (spawnedProjectiles[0] < 25 &&
            projectileSpawners[0].GetComponent<SpawnProjectiles>().allSpawned)
            {
            spawnedProjectiles[0] += 2;
            projectileSpawners[0].GetComponent<SpawnProjectiles>().totalNumberOfProjectiles = spawnedProjectiles[0];
            projectileSpawners[0].GetComponent<SpawnProjectiles>().allSpawned = false;
            round++;
            spawnObj.GetComponent<spawnObj>().moneySum += 600;
            }

            //chained rock
            if (spawnedProjectiles[1] < 20 &&
                    projectileSpawners[1].GetComponent<SpawnProjectiles>().allSpawned)
            {
                spawnedProjectiles[1] += 1;
                projectileSpawners[1].GetComponent<SpawnProjectiles>().totalNumberOfProjectiles = spawnedProjectiles[1];
                projectileSpawners[1].GetComponent<SpawnProjectiles>().allSpawned = false;
            }
            //explosion bomb
            if (spawnedProjectiles[2] < 15 &&
                projectileSpawners[2].GetComponent<SpawnProjectiles>().allSpawned)
            {
                spawnedProjectiles[2] = 1;
                projectileSpawners[2].GetComponent<SpawnProjectiles>().totalNumberOfProjectiles = spawnedProjectiles[2];
                projectileSpawners[2].GetComponent<SpawnProjectiles>().allSpawned = false;
            }
            //implosion bomb
            if (spawnedProjectiles[3] < 15 &&
                    projectileSpawners[3].GetComponent<SpawnProjectiles>().allSpawned)
            {
                spawnedProjectiles[3] = 1;
                projectileSpawners[3].GetComponent<SpawnProjectiles>().totalNumberOfProjectiles = spawnedProjectiles[3];
                projectileSpawners[3].GetComponent<SpawnProjectiles>().allSpawned = false;

            }
        }
       
        // find all pigs
        //GameObject[] pigList = GameObject.FindGameObjectsWithTag("pig");
        //for(int i = 0; i < pigList.)
        //    targetDmg tScript = g.GetComponent<targetDmg>();
        //    if (tScript.hp <= 0)
        //    // wait 3 sec then start function
        //        StartCoroutine(CheckLvlBeat(pigList));

        //arrows.SetActive(false);
    }

    //IEnumerator CheckLvlBeat(GameObject[] pList)
    //{
    //    yield return new WaitForSeconds(3);
    //    bool allAlive = true;
    //    foreach (GameObject g in pList)
    //    {
    //        // check if hp <= 0
    //        targetDmg tScript = g.GetComponent<targetDmg>();
    //        if (tScript.hp <= 0)
    //        {
    //            allAlive = false;
    //        }
    //    }
    //    if (allAlive == false)
    //    {
    //        // start level again
    //        loseTxt.SetActive(true);
    //        yield return new WaitForSeconds(2);
    //        Application.LoadLevel("main menu");
    //    }
    //    else
    //    {
    //        //rndTxt.SetActive(true);

    //        yield return new WaitForSeconds(2);
    //        round++;




    //    }
    //}
}
