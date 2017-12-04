using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Toque : MonoBehaviour {

    public GameObject somToque;

    // Use this for initialization
    void Start () {
        somToque.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseEnter()
    {
        if (GameManager.Instance.verificarConvite() == 0)
        {
            somToque.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        if (GameManager.Instance.verificarConvite() == 0)
        {
            somToque.SetActive(false);
        }
    }
    
    public void atende()
    {
        if (GameManager.Instance.verificarConvite() == 0)
        {
            StartCoroutine("atendeCelular");
        }
    }

    IEnumerator atendeCelular()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Celular");
    }
}
