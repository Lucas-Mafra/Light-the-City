using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNextScene : MonoBehaviour {

	// Use this for initialization
	public void changeScene  () {
		SceneManager.LoadScene ("Game");

	}
}
