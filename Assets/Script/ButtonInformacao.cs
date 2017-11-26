using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInformacao : MonoBehaviour {

    public GameObject informacao;
    public bool visivel;

	// Use this for initialization
	void Start () {
        visivel = false;
	}

    void Update()
    {
        informacao.SetActive(visivel);
    }

    public void buttonInformacao()
    {
        visivel = !visivel;
    }
}
