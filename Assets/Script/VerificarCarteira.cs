using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificarCarteira : MonoBehaviour {

    public ContagemDesafil cont;
    private Transform player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Carteira").transform;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Carteira")
        {
            cont.ganhaPonto();
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
        }
    }
}
