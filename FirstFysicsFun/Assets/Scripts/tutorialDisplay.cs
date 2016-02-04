using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutorialDisplay : MonoBehaviour {
    public GameObject b1, b2, b3, b4, b5, b6;
    public int amountButtons;
    private GameObject[] textList;
    public int buttonIndex = 0;
    public GameObject pSpawner;

    IEnumerator Wait()
    {
        Debug.Log(Time.time);

        float timeToWait = 1.0f;
        while (timeToWait >= 0f)
        {
            timeToWait -= Time.unscaledDeltaTime;
            yield return null;
        }
        ActivateText();
    }

    void Start () {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        // make transparent
        r.color = new Vector4(1f, 1f, 1f, .75f);
        // put buttons into list
        textList = new GameObject[amountButtons];
        textList[0] = b1;
        textList[1] = b2;
        textList[2] = b3;
        textList[3] = b4;
        textList[4] = b5;
        textList[5] = b6;
        //pause game
        Time.timeScale = 0;

        textList[buttonIndex].SetActive(true);
    }

    // to exit out of tut mode
    void OnMouseDown()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        // make completely clear
        r.color = new Vector4(1f, 1f, 1f, 0f);

        // disable text
        textList[buttonIndex].SetActive(false);

        if (buttonIndex < amountButtons-1)
            StartCoroutine( Wait());
    }

    void Update()
    {
        if (buttonIndex == amountButtons-1)
        {
            pSpawner.SetActive(true);
        }
        if (buttonIndex >= amountButtons)
        {
            for (int i = 0; i < amountButtons; i++)
            {
                textList[i].SetActive(false);
            }
            foreach(GameObject g in textList)
            { g.SetActive(false); }
        }

        // for testing purposes
        if(Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("level 1");
            //GameObject.FindGameObjectWithTag("tut display").SetActive(false);
        }
    }


    // call when time to display text
    void ActivateText()
    {
        if(buttonIndex < amountButtons)
        // increment text
            buttonIndex++;
        
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        // make transparent
        r.color = new Vector4(1f, 1f, 1f, .75f);
        

        textList[buttonIndex].SetActive(true);

        
    }
}
