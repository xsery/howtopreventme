using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudançaDePersonagem : MonoBehaviour {

    private Animator animator;
    public int personagem;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetInteger("Personagem", GameManager.Instance.consultarPersonagem());
        personagem = GameManager.Instance.consultarPersonagem();
    }
}
