using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContagemDesafil : MonoBehaviour {

    public Text mensagem;
    public int Contagem;
    public GameObject objeto;

	// Use this for initialization
	void Start () {
        Contagem = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Contagem == 11)
        {
            GameManager.Instance.ganhaCincoPonto();
            mensagem.text = "Você esta preparado para balada.\nVocê ganhou 5 pontos.\nAté a próxima;";
            objeto.SetActive(false);
        }
	}

    public void ganhaPonto()
    {
        Contagem++;
    }


}
