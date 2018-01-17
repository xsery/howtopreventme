using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MoveQuadrado : MonoBehaviour {

    private Transform player;
    public int quad;
    public GameObject titulo1;
    public GameObject titulo2;
    public GameObject titulo3;
    public GameObject titulo4;
    public GameObject titulo5;
    public GameObject titulo6;

    // Use this for initialization
    void Start()
    {
        if(quad == 1)
        {
            player = GameObject.FindGameObjectWithTag("Diafragma").transform;
        } else {
            if (quad == 2)
            {
                player = GameObject.FindGameObjectWithTag("Camisinha").transform;
            }
            else
            {
                if (quad == 3)
                {
                    player = GameObject.FindGameObjectWithTag("InjecaoAnticoncepcional").transform;
                }
                else
                {
                    if (quad == 4)
                    {
                        player = GameObject.FindGameObjectWithTag("PilulaDiaSeguinte").transform;
                    }
                    else
                    {
                        if (quad == 5)
                        {
                            player = GameObject.FindGameObjectWithTag("PilulaAnticoncepcional").transform;
                        }
                        else
                        {
                            if (quad == 6)
                            {
                                player = GameObject.FindGameObjectWithTag("DIU").transform;
                            }
                        }
                    }
                }
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if ((colisor.gameObject.tag == "Diafragma") && (quad == 1))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo1.SetActive(false);
        }
        if ((colisor.gameObject.tag == "Camisinha") && (quad == 2))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo2.SetActive(false);
        }
        if ((colisor.gameObject.tag == "InjecaoAnticoncepcional") && (quad == 3))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo3.SetActive(false);
        }
        if ((colisor.gameObject.tag == "PilulaDiaSeguinte") && (quad == 4))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo4.SetActive(false);
        }
        if ((colisor.gameObject.tag == "PilulaAnticoncepcional") && (quad == 5))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo5.SetActive(false);
        }
        if ((colisor.gameObject.tag == "DIU") &&  (quad == 6))
        {
            GameManager.Instance.ganhaUmPonto();
            gameObject.SetActive(false);
            titulo6.SetActive(false);
        }
    }
}
