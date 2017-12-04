using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonShopping : MonoBehaviour {

    public void shopping()
    {
        StartCoroutine("scene");
    }

    IEnumerator scene()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/Shopping");
    }
}
