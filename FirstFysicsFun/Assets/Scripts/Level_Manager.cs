using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Level_Manager : MonoBehaviour {

	public Button currButton;

	public void LoadLevel()
	{
		Application.LoadLevel (1);
	}
}
