using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtualizarPontos : MonoBehaviour {

    public Text pontos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pontos.text = GameManager.Instance.getScoreText();
	}
}
