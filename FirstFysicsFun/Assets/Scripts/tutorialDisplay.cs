using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutorialDisplay : MonoBehaviour {
    public GameObject b1, b2, b3, b4, b5;
    private GameObject[] textList;
    public int buttonIndex = 0;

	void Start () {
        SpriteRenderer r = GetComponent<SpriteRenderer>();
        // make transparent
        r.color = new Vector4(1f, 1f, 1f, .75f);

        textList = new GameObject[5];
        textList[0] = b1;
        textList[1] = b2;
        textList[2] = b3;
        textList[3] = b4;
        textList[4] = b5;
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

        // game unpause
        //Time.timeScale = 1;

        // disable text
        textList[buttonIndex].SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ActivateText();
            Debug.Log("pressed");
        }
    }


    // call when time to display text
    void ActivateText()
    {
        if(buttonIndex < 4)
        // increment text
            buttonIndex++;

        SpriteRenderer r = GetComponent<SpriteRenderer>();
        // make transparent
        r.color = new Vector4(1f, 1f, 1f, .75f);
        

        textList[buttonIndex].SetActive(true);
        //activeText.enabled = true;
    }
}
