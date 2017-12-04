using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrocaFalaEscolaMasculina : MonoBehaviour {

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public GameObject professora;
    public GameObject btnPassa;
    public Image personagem;
    public Text fala;
    public int contFala;
    public GameObject desafio;
    public GameObject opcoes;
    public GameObject buttonPassa;
    public ButtonInterrogacao buttonInterrogacao;

    // Use this for initialization
    void Start()
    {
        professora.SetActive(true);
        buttonPassa.SetActive(true);
        trocaDeFala();
        desafio.SetActive(false);
        opcoes.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonInterrogacao.terminou == true)
        {
            GameManager.Instance.ganhaCincoPonto();
            professora.SetActive(true);
            desafio.SetActive(false);
            opcoes.SetActive(false);
            buttonPassa.SetActive(false);
        }
    }

    public void trocaDeFala()
    {
        if (contFala == 0)
        {
            fala.text = "Olá, sou a professora\nRosana! Vamos compartilhar\nconhecimentos?";
            personagem.sprite = sprite1;
            btnPassa.SetActive(true);
        }
        if (contFala == 1)
        {
            fala.text = "Você saberia identificar as partes\ndo sistema reprodutor\nmasculino?";
            personagem.sprite = sprite2;
        }
        if (contFala == 2)
        {
            fala.text = "Poderia me ajudar? Vamos lá! A\ncada acerto, você ganhará 1\nponto. Ao errar, você poderá\ntentar novamente...";
            personagem.sprite = sprite3;
        }
        if (contFala == 3)
        {
            fala.text = "Muito bem!! Você acertou todas!!\nGanhou 5 pontos! Então... até a\npróxima!";
            personagem.sprite = sprite4;
            professora.SetActive(false);
            btnPassa.SetActive(false);
            desafio.SetActive(true);
            opcoes.SetActive(true);
        }
        contNemFala();
    }

    public void contNemFala()
    {
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
