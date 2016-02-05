using UnityEngine;
using System.Collections;

public class SpawnProjectiles : MonoBehaviour {

    public int totalNumberOfProjectiles;
    public int numberOfProjectilesSpawned;
    public bool allAlive;
    private int round;
    public bool allSpawned;
    private string currentLevel;
    //public Object prefab;
    public GameObject g, go, arrows, winTxt, loseTxt;
    public float projectileSize;

    private float spawnDelay;
    private float time;

    IEnumerator CheckLvlBeat(GameObject[] pList)
    {
  
        yield return new WaitForSeconds(3);

        allAlive = true;
        winTxt.SetActive(false);
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
            Debug.Log("one is dead");
            // start level again
            loseTxt.SetActive(true);

            yield return new WaitForSeconds(2);

            if (currentLevel == "level 1")
                Application.LoadLevel("level 1");
            if (currentLevel == "Level 2")
                Application.LoadLevel("Level 2");

        }
        else
        {
            Debug.Log("lvl passed");
            //round++;
            // managment.GetComponent<Management>().round = round;
            winTxt.SetActive(true);

            yield return new WaitForSeconds(5);
           
            if (currentLevel == "level 1")
            {
                
                
                Application.LoadLevel("main menu");

            }
            //allSpawned = false;
        }
        if(allAlive)
            numberOfProjectilesSpawned = 0;
    }

    // Use this for initialization
    void Start ()
    {
        round = 1;
      
        allSpawned = true;
        time = 0;
        spawnDelay = .6f;
        //arrows = Instantiate(arrows, arrows.transform.position, Quaternion.identity) as GameObject;
        arrows.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        currentLevel = Application.loadedLevelName;
        if (time > spawnDelay)
        {
            //spawn
            if (numberOfProjectilesSpawned <= totalNumberOfProjectiles)
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
                
                allSpawned = true;
                

                // find all pigs
                GameObject[] pigList = GameObject.FindGameObjectsWithTag("pig");

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
