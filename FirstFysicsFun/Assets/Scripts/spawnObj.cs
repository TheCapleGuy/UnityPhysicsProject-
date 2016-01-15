using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawnObj : MonoBehaviour {
    public GameObject wood, brick, fan, spinSword, wreckBall;
    public Button woodB, brickB, fanB, wBallB, sSwordB;

	public void SpawnBrick ()
    {
        Instantiate(brick, new Vector3(0, -1, 0), Quaternion.identity);
        
    }
	
	public void SpawnWood()
    {
		Instantiate (wood, new Vector3(0,-1,0), Quaternion.identity);
	}

    public void SpawnFan()
    {
        Instantiate(fan, new Vector3(0, -1, 0), Quaternion.identity);
    }

    public void SpawnSpinSword()
    {
        Instantiate(spinSword, new Vector3(0, -1, 0), Quaternion.identity);
    }

    public void SpawnWreckBall()
    {
        Instantiate(wreckBall, new Vector3(0, -1, 0), Quaternion.identity);
    }

    public void enableButton()
    {
        Time.timeScale = 0f;
        if (woodB.GetComponent<Button>().IsInteractable() == false)
        {
            Time.timeScale = 0f;

            fanB.GetComponent<Button>().interactable = true;
            wBallB.GetComponent<Button>().interactable = true;
            sSwordB.GetComponent<Button>().interactable = true;

            woodB.GetComponent<Button>().interactable = true;
            //woodB.GetComponent<Image>().enabled = true;
            //woodB.GetComponentInChildren<Text>().enabled = true;
            brickB.GetComponent<Button>().interactable = true;
            //brickB.GetComponent<Image>().enabled = true;
            //brickB.GetComponentInChildren<Text>().enabled = true;
        }
        else
        {
            Time.timeScale = 1f;
            fanB.GetComponent<Button>().interactable = false;
            wBallB.GetComponent<Button>().interactable = false;
            sSwordB.GetComponent<Button>().interactable = false;

            woodB.GetComponent<Button>().interactable = false;
            brickB.GetComponent<Button>().interactable = false;
            /*woodB.GetComponent<Image>().enabled = false;
            brickB.GetComponent<Image>().enabled = false;
            woodB.GetComponentInChildren<Text>().enabled = false;
            brickB.GetComponentInChildren<Text>().enabled = false;*/
        }
    }
}
