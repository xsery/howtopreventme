using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarBoca : MonoBehaviour {

    public ContagemAtividade cont;
    private Transform player;
    public GameObject objeto;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Boca").transform;
        objeto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Boca")

        {
            cont.ganhaPonto();
            gameObject.SetActive(false);
            objeto.SetActive(true);
        }
    }
}
