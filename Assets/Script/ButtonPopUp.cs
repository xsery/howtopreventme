using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPopUp : MonoBehaviour {

    public GameObject resposta;
    public GameObject resposta1;
    public GameObject resposta2;
    public GameObject resposta3;
    public GameObject resposta4;
    public GameObject resposta5;
    public GameObject resposta6;
    public GameObject resposta7;
    public GameObject popup;
    public ButtonInterrogacao buttonInterrogacao;

    // Use this for initialization
    void Start () {
        popup.SetActive(false);
        resposta.SetActive(true);
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        resposta4.SetActive(false);
        resposta5.SetActive(false);
        resposta6.SetActive(false);
        resposta7.SetActive(false);
        buttonInterrogacao.contFala = -1;
        continuar();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void popUp()
    {
        popup.SetActive(true);
        resposta.SetActive(false);
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        resposta4.SetActive(false);
        resposta5.SetActive(false);
        resposta6.SetActive(false);
        resposta7.SetActive(false);
    }

    public void continuar()
    {
        popup.SetActive(false);
        buttonInterrogacao.trocaDeFala();
        if (buttonInterrogacao.contFala == 0)
        {
            resposta.SetActive(true);
            resposta1.SetActive(false);
            resposta2.SetActive(false);
            resposta3.SetActive(false);
            resposta4.SetActive(false);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 1)
        {
            resposta.SetActive(false);
            resposta1.SetActive(true);
            resposta2.SetActive(false);
            resposta3.SetActive(false);
            resposta4.SetActive(false);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 2)
        {
            resposta.SetActive(false);
            resposta1.SetActive(false);
            resposta2.SetActive(true);
            resposta3.SetActive(false);
            resposta4.SetActive(false);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 3)
        {
            resposta.SetActive(false);
            resposta1.SetActive(false);
            resposta2.SetActive(false);
            resposta3.SetActive(true);
            resposta4.SetActive(false);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 4)
        {
            resposta.SetActive(false);
            resposta1.SetActive(false);
            resposta2.SetActive(false);
            resposta3.SetActive(false);
            resposta4.SetActive(true);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 5)
        {
            resposta.SetActive(false);
            resposta1.SetActive(false);
            resposta2.SetActive(false);
            resposta3.SetActive(false);
            resposta4.SetActive(false);
            resposta5.SetActive(true);
            resposta6.SetActive(true);
            resposta7.SetActive(false);
        }
        if (buttonInterrogacao.contFala == 6)
        {
            resposta.SetActive(false);
            resposta1.SetActive(false);
            resposta2.SetActive(false);
            resposta3.SetActive(false);
            resposta4.SetActive(false);
            resposta5.SetActive(false);
            resposta6.SetActive(false);
            resposta7.SetActive(true);
        }
    }
}
