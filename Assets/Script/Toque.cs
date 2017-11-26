using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Toque : MonoBehaviour {

    public Text textToque;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseEnter()
    {
        StartCoroutine("vibrar");
    }

    public void atende()
    {
        StartCoroutine("atendeCelular");
    }

    IEnumerator vibrar()
    {
        textToque.text = "TRIMMMMMM!!!";
        yield return new WaitForSeconds(10f);
        textToque.text = "Atende o telefone!";
        yield return new WaitForSeconds(10f);
        textToque.text = "TRIMMMMMM!!!";
    }

    IEnumerator atendeCelular()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Celular");
    }
}
