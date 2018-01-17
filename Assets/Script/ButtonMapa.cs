using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMapa : MonoBehaviour {

	public void mapa()
    {
        StartCoroutine("sceneMapa");
    }

    IEnumerator sceneMapa()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Intro");
    }
}
