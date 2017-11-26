using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scene_healthycare : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0) && GameObject.Find("option1"))
		{
			SceneManager.LoadScene(6);
		}
		if (Input.GetMouseButtonDown(0) && GameObject.Find("option2"))
		{
			SceneManager.LoadScene(7);
		}
		if (Input.GetMouseButtonDown(0) && GameObject.Find("option3"))
		{
			SceneManager.LoadScene(6);
		}
		if (Input.GetMouseButtonDown(0) && GameObject.Find("option4"))
		{
			SceneManager.LoadScene(6);
		}
		if (Input.GetMouseButtonDown(0) && GameObject.Find("option5"))
		{
			SceneManager.LoadScene(6);
		}
		if (Input.GetMouseButtonDown(0) && GameObject.Find("option6"))
		{
			SceneManager.LoadScene(6);
		}
	}
}
