using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsPostoDeSaude1 : MonoBehaviour {

    public GameObject Cena1;
    public GameObject CenaFinal;
    public GameObject DesafioUI;
    public GameObject Desafio;

    public void IrCena1()
    {
        Cena1.SetActive(true);
        CenaFinal.SetActive(false);
        Desafio.SetActive(false);
        DesafioUI.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {
        IrCena1();
    }

    public void IrCenaFinal()
    {
        Cena1.SetActive(false);
        CenaFinal.SetActive(true);
        Desafio.SetActive(false);
        DesafioUI.SetActive(false);
    }

    public void IrDesafio()
    {
        Cena1.SetActive(false);
        CenaFinal.SetActive(false);
        Desafio.SetActive(true);
        DesafioUI.SetActive(true);
    }

    public void IrContinue()
    {
        GameManager.Instance.ganhaCincoPonto();
        Cena1.SetActive(false);
        CenaFinal.SetActive(true);
        Desafio.SetActive(false);
        DesafioUI.SetActive(false);
    }
}
