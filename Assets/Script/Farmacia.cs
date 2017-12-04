using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Farmacia : MonoBehaviour {

    public GameObject sim;
    public GameObject nao;
    public Text balao;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Sim()
    {
        sim.SetActive(false);
        nao.SetActive(false);
        balao.text = "Você sabia que é possível retirar gratuitamente alguns métodos anticoncepcionais no posto de saúde?" +
            " Por que você não dá uma passadinha lá?";
    }

    public void Não()
    {
        StartCoroutine("armario");
    }

    IEnumerator armario()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene/FarmaciaArmario");
    }
}
