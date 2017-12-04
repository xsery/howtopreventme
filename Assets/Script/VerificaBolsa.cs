using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificaBolsa : MonoBehaviour {

    private Transform player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Bolsa").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        Debug.Log("Objeto encostou em " + colisor.gameObject.name);
        if (colisor.gameObject.tag == "Bolsa")
        {
            gameObject.SetActive(false);
        }
    }
}
