using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsEscolaSexo : MonoBehaviour {

    public GameObject Cena1;
    public GameObject Cena2;
    public GameObject CenaFinal;
    public GameObject Opcoes;
    public GameObject CenaSexoVaginal;
    public GameObject CenaSexoOral1;
    public GameObject CenaSexoOral2;
    public GameObject CenaSexoAnal1;
    public GameObject CenaSexoAnal2;

    public void IrCena1()
    {
        Cena1.SetActive(true);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        IrCena1();
	}

    public void IrCena2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(true);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaFinal()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(true);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrOpcoes()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(true);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaSexoVaginal()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(true);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaSexoOral1()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(true);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaSexoOral2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(true);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaSexoAnal1()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(true);
        CenaSexoAnal2.SetActive(false);
    }

    public void IrCenaSexoAnal2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        CenaSexoVaginal.SetActive(false);
        CenaSexoOral1.SetActive(false);
        CenaSexoOral2.SetActive(false);
        CenaSexoAnal1.SetActive(false);
        CenaSexoAnal2.SetActive(true);
    }
}
