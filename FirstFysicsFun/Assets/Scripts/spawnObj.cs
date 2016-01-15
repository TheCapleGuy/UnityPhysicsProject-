using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawnObj : MonoBehaviour {
    public GameObject wood, brick, fan, spinSword, wreckBall;
    public Button woodB, brickB, fanB, wBallB, sSwordB, moneySumB;
    public float woodValue, brickValue, fanValue, spinSwordValue, wreckBallValue, moneySum;
    private Text woodText, brickText, fanText, wreckingBallText, swingingSwordText, moneyDisplayText;

    void Start()
    {
        woodText = woodB.GetComponentInChildren<Text>();
        woodText.text += "$" + woodValue;

        brickText = brickB.GetComponentInChildren<Text>();
        brickText.text += "$" + brickValue;

        fanText = fanB.GetComponentInChildren<Text>();
        fanText.text += "$" + fanValue;

        wreckingBallText = wBallB.GetComponentInChildren<Text>();
        wreckingBallText.text += "$" + wreckBallValue;

        swingingSwordText = sSwordB.GetComponentInChildren<Text>();
        swingingSwordText.text += "$" + spinSwordValue;

        moneyDisplayText = moneySumB.GetComponentInChildren<Text>();
        moneyDisplayText.text += moneySum;
    }

    void UpdateMoneyLeftDisplay()
    {
        //clear the box displaying the amount of money left
        moneyDisplayText.text = null;
        // reset the box text because the moneySum has changed
        moneyDisplayText.text = "Money Left: " + moneySum;
    }

    public void SpawnBrick ()
    {
        if (moneySum > brickValue)
        {
            Instantiate(brick, new Vector3(0, -1, 0), Quaternion.identity);
            moneySum -= brickValue;
            UpdateMoneyLeftDisplay();
        }
            
    }
	
	public void SpawnWood()
    {
        if (moneySum > woodValue)
        {
            Instantiate(wood, new Vector3(0, -1, 0), Quaternion.identity);
            moneySum -= woodValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void SpawnFan()
    {
        if (moneySum > fanValue)
        { 
            Instantiate(fan, new Vector3(0, -1, 0), Quaternion.identity);
            moneySum -= fanValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void SpawnSpinSword()
    {
        if (moneySum > spinSwordValue)
        {
            Instantiate(spinSword, new Vector3(0, -1, 0), Quaternion.identity);
            moneySum -= spinSwordValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void SpawnWreckBall()
    {
        if (moneySum > wreckBallValue)
        {
            Instantiate(wreckBall, new Vector3(0, -1, 0), Quaternion.identity);
            moneySum -= wreckBallValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void enableButton()
    {
        Time.timeScale = 0f;
        if (woodB.GetComponent<Button>().IsInteractable() == false)
        {
            Time.timeScale = 0f;

            woodB.interactable = true;
            brickB.interactable = true;
            fanB.interactable = true;
            wBallB.interactable = true;
            sSwordB.interactable = true;
        }
        else
        {
            Time.timeScale = 1f;
            fanB.interactable = false;
            wBallB.interactable = false;
            sSwordB.interactable = false;

            woodB.interactable = false;
            brickB.interactable = false;
            /*woodB.GetComponent<Image>().enabled = false;
            brickB.GetComponent<Image>().enabled = false;
            woodB.GetComponentInChildren<Text>().enabled = false;
            brickB.GetComponentInChildren<Text>().enabled = false;*/
        }
    }
}
