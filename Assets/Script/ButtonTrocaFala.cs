using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrocaFala : MonoBehaviour {

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public GameObject consciencia;
    public GameObject btnPassa;
    public Image personagem;
    public Text fala;
    public int contFala;
    

	// Use this for initialization
	void Start () {
        if (GameManager.Instance.verificarConvite() == 0)
        {
            consciencia.SetActive(false);
        }
        if (GameManager.Instance.verificarConvite() == 1)
        {
            consciencia.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void trocaDeFala()
    {
        if (contFala == 0) {
            fala.text = "Olá! Meu nome é Consciência! Vamos jogar e\nganhar PONTOS?? rsrs";
            personagem.sprite = sprite1;
            btnPassa.SetActive(true);
        }
        if (contFala == 1)
        {
            fala.text = "Antes de ir se divertir, o que poderia\nou deveria ser levado dentro da sua carteira ou\nda sua bolsa?";
            personagem.sprite = sprite2;
        }
        if (contFala == 2)
        {
            fala.text = "Arraste cada item abaixo para a carteira ou\npara a bolsa!";
            personagem.sprite = sprite3;
        }
        if (contFala == 3)
        {
            fala.text = "Arraste cada item abaixo para a carteira ou\npara a bolsa ao lado!";
            personagem.sprite = sprite4;
            btnPassa.SetActive(false);
        }
        if (contFala >= 3)
        {
            contFala = 0;
        }
        else
        {
            contFala++;
        }

    }
}
