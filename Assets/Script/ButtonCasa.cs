using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCasa : MonoBehaviour {

    public int comodo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void comodos()
    {
        StartCoroutine("irAosComodos");
    }

    IEnumerator irAosComodos(){
        if (comodo == 0)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Sala");
        }
        if (comodo == 1)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Banheiro");
        }
        if (comodo == 2)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Cozinha");
        }
        if (comodo == 3)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Lavanderia");
        }
        if (comodo == 4)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Quarto");
        }
        if (comodo == 5)
        {
            float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Scene/Celular");
        }
    }
}
