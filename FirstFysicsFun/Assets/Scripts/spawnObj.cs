using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawnObj : MonoBehaviour {
    public Camera cam;
    public GameObject wood, brick, fan, spinSword, wreckBall;
    public Button woodB, brickB, fanB, wBallB, sSwordB, moneySumB;
    public float woodValue, brickValue, fanValue, spinSwordValue, wreckBallValue, moneySum, rotateSpeed;

    private Text woodText, brickText, fanText, wreckingBallText, swingingSwordText, moneyDisplayText;
    private Vector3 mouseLocInWorldSpace;
    private Vector3 mousePos;
    private Transform t;
    public  GameObject selectedObj, emptyGameObject;
    private bool rotating;
    private Quaternion rotation;
    void SetText()
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

    void Start()
    {
        SetText();
        selectedObj = emptyGameObject = new GameObject();
        rotating = false;
    }

    public void OnDrag()
    {
        selectedObj.transform.position = mouseLocInWorldSpace;
    }

    public void EndDrag()
    {
        rotating = true;
    }


    public void RotateObj()
    {
        if (rotating) //selectedObj.transform.LookAt(mouseLocInWorldSpace, transform.up);
        {
            selectedObj.transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);          
        }
        //deselect the obj and rotate the z to make 
        //the obj's collider face the camera
        if (Input.GetMouseButtonDown(0))
        {
            selectedObj = emptyGameObject;
            rotating = false;
        }
    }

    void Update()
    {
        if (selectedObj != emptyGameObject)
            //rotation = Quaternion.Euler(mouseLocInWorldSpace.x, mouseLocInWorldSpace.y, 0);
            rotation = Quaternion.LookRotation(
                                 /*Input.mousePosition - selectedObj.transform.position,*/
                                 mouseLocInWorldSpace - selectedObj.transform.position,
                                 selectedObj.transform.TransformDirection(Vector3.up));
        //--------- manually set z to 1
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        
        mouseLocInWorldSpace = cam.ScreenToWorldPoint(mousePos);
        RotateObj();
    }

    void UpdateMoneyLeftDisplay()
    {
        //clear the box displaying the amount of money left
        moneyDisplayText.text = null;
        // reset the box text because the moneySum has changed
        if(moneySum < 100) // for neatness
            moneyDisplayText.text = "Money Left: " + 0 + moneySum;
        else
            moneyDisplayText.text = "Money Left: " + moneySum;
    }

    public void SpawnBrick ()
    {
        if (moneySum >= brickValue && brickB.IsInteractable())
        {
            selectedObj = Instantiate(brick, mouseLocInWorldSpace, Quaternion.identity) as GameObject;
            //selectedObj = t.gameObject;
            Debug.Log(mouseLocInWorldSpace + "Where obj spawned");
            moneySum -= brickValue;
            UpdateMoneyLeftDisplay();
        }
    }
	
	public void SpawnWood()
    {
        if (moneySum >= woodValue && woodB.IsInteractable())
        {
            selectedObj = Instantiate(wood, mouseLocInWorldSpace, Quaternion.identity) as GameObject;

            Debug.Log(mouseLocInWorldSpace + "Where obj spawned");
            moneySum -= woodValue;
            UpdateMoneyLeftDisplay();

            //need to know this function has been triggered
        }
    }

    public void SpawnFan()
    {
        if (moneySum >= fanValue && fanB.IsInteractable())
        {
            selectedObj = Instantiate(fan, mouseLocInWorldSpace, Quaternion.identity) as GameObject;
            //selectedObj = t.gameObject;
            Debug.Log(mouseLocInWorldSpace + "Where obj spawned");
            moneySum -= fanValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void SpawnSpinSword()
    {
        if (moneySum >= spinSwordValue && sSwordB.IsInteractable())
        {
            selectedObj = Instantiate(spinSword, mouseLocInWorldSpace, Quaternion.identity) as GameObject;
            //selectedObj = t.gameObject;
            Debug.Log(mouseLocInWorldSpace + "Where obj spawned");
            moneySum -= spinSwordValue;
            UpdateMoneyLeftDisplay();
        }
    }

    public void SpawnWreckBall()
    {
        if (moneySum >= wreckBallValue && wBallB.IsInteractable())
        {
            selectedObj = Instantiate(wreckBall, mouseLocInWorldSpace, Quaternion.identity) as GameObject;
            //selectedObj = t.gameObject;
            Debug.Log(mouseLocInWorldSpace + "Where obj spawned");
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
