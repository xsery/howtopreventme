using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonConvite : MonoBehaviour {

    public Text resposta;
    public GameObject buttonAceita;
    public GameObject buttonRecusa;
    public GameObject textResposta;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void aceitar()
    {
        resposta.text = "OK. Até a próxima!";
        buttonAceita.SetActive(false);
        buttonRecusa.SetActive(false);
        textResposta.SetActive(true);
        GameManager.Instance.aceitarConvite();
        StartCoroutine("retornaAoQuarto");
    }

    public void recusar()
    {
        resposta.text = "Beleza!! Até mais!!";
        buttonAceita.SetActive(false);
        buttonRecusa.SetActive(false);
        textResposta.SetActive(true);
        GameManager.Instance.recusarConvite();
        StartCoroutine("retornaAoQuarto");
    }

    IEnumerator retornaAoQuarto()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Quarto");
    }
}