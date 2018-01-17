using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSaudeMapa : MonoBehaviour
{
    public GameObject despedida;
    public GameObject intro;
    public GameObject desafio;
    public GameObject desafio2;

    public void mapa()
    {
        StartCoroutine("sceneMapa");
        despedida.SetActive(true);
        intro.SetActive(false);
        desafio.SetActive(false);
        desafio2.SetActive(false);
    }

    IEnumerator sceneMapa()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Scene/Mapa");
    }

    public void proximo()
    {
        despedida.SetActive(false);
        intro.SetActive(false);
        desafio.SetActive(true);
        desafio2.SetActive(true);
    }
}