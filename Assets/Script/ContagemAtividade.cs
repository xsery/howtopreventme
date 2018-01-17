using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContagemAtividade : MonoBehaviour {

    public int Contagem;
    public GameObject PopUp;

    // Use this for initialization
    void Start()
    {
        Contagem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Contagem == 7)
        {
            GameManager.Instance.ganhaCincoPonto();
            PopUp.SetActive(true);
        }
    }

    public void ganhaPonto()
    {
        Contagem++;
    }
}
