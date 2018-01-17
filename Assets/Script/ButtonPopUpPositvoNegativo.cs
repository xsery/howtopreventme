using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPopUpPositvoNegativo : MonoBehaviour {

    public GameObject positivo;
    public GameObject negativo;
    public bool visivelPositivo;
    public bool visivelNegativo;

    // Use this for initialization
    void Start()
    {
        visivelPositivo = false;
        visivelNegativo = false;
    }

    void Update()
    {
        positivo.SetActive(visivelPositivo);
        negativo.SetActive(visivelNegativo);
    }

    public void buttonPositivo()
    {
        visivelPositivo = !visivelPositivo;
        visivelNegativo = false;
    }

    public void buttonNegativo()
    {
        visivelNegativo = !visivelNegativo;
        visivelPositivo = false;
    }
}
