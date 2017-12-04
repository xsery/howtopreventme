using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHospital : MonoBehaviour {

    public GameObject popup;
    public Text tema;
    public Text conteudo;
    public Text button;
    public bool concluida;

	// Use this for initialization
	void Start () {
        popup.SetActive(false);
        concluida = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void errado()
    {
        tema.text = "Errado!";
        conteudo.text = "Este método NÃO previne contra as doenças\nsexualmente transmissíveis. :(\nTente novamente!";
        button.text = "Continue";
        popup.SetActive(true);
        concluida = false;
    }

    public void certo()
    {
        tema.text = "Correto!";
        conteudo.text = "Isso mesmo! Tanto a camisinha masculina quanto a\nfeminina são capazes de previnirem uma gravidez\n" +
            "indesejada e as doenças sexualmente transmissíveis!";
        button.text = "OK";
        GameManager.Instance.ganhaCincoPonto();
        popup.SetActive(true);
        concluida = true;
    }

    public void botao()
    {
        if (concluida)
        {
            ok();
        }
        else
        {
            continuar();
        }
    }

    public void continuar()
    {
        popup.SetActive(false);
    }

    public void ok()
    {
        StartCoroutine("sceneMapa");
    }

    IEnumerator sceneMapa()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Mapa");
    }
}
