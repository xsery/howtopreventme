using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIniciar : MonoBehaviour {

    //public AudioSource button;

    public void Play()
    {
        //button.Play();
        StartCoroutine("menu");
    }

    IEnumerator menu()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Personagem");
    }
}
