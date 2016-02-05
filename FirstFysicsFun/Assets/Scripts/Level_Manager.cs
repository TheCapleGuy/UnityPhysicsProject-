using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Level_Manager : MonoBehaviour {

	public Button currButton;

	public void LoadLevel()
	{
		Application.LoadLevel (1);
	}
    public void LoadLevel2()
    {
        Application.LoadLevel("Level 2");
    }
}
