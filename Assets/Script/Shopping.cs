using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shopping : MonoBehaviour {

    public int loja;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void lojas()
    {
        StartCoroutine("entrandoLoja");
    }

    IEnumerator entrandoLoja()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        if(loja == 1){
            SceneManager.LoadScene("Scene/LojaLotado");
        }
        else
        {
            if (loja == 2)
            {
                SceneManager.LoadScene("Scene/Chapeus");
            }
            else
            {
                if (loja == 3)
                {
                    SceneManager.LoadScene("Scene/Perfumaria");
                }
                else
                {
                    if (loja == 4)
                    {
                        SceneManager.LoadScene("Scene/Musica");
                    }
                    else
                    {
                        SceneManager.LoadScene("Scene/Livraria");
                    }
                }
            }
        }
    }
}
