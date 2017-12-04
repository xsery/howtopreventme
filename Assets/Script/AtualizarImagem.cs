using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtualizarImagem : MonoBehaviour {

	public Sprite personagem1;
    public Sprite personagem2;
    public Sprite personagem3;
    public Sprite personagem4;
    public Sprite personagem5;
    public Sprite personagem6;
    public Sprite personagem7;
    public Sprite personagem8;
    public Sprite personagem9;
    public Sprite personagem10;
    public Sprite personagem11;
    public Sprite personagem12;
    public Image personagem;

    // Use this for initialization
    void Start()
    {
        if (GameManager.Instance.getPersonagem() == 0)
        {
            personagem.sprite = personagem1;
        }
        else
        {
            if (GameManager.Instance.getPersonagem() == 1)
            {
                personagem.sprite = personagem2;
            }
            else
            {
                if (GameManager.Instance.getPersonagem() == 2)
                {
                    personagem.sprite = personagem3;
                }
                else
                {
                    if (GameManager.Instance.getPersonagem() == 3)
                    {
                        personagem.sprite = personagem4;
                    }
                    else
                    {
                        if (GameManager.Instance.getPersonagem() == 4)
                        {
                            personagem.sprite = personagem5;
                        }
                        else
                        {
                            if (GameManager.Instance.getPersonagem() == 5)
                            {
                                personagem.sprite = personagem6;
                            }
                            else
                            {
                                if (GameManager.Instance.getPersonagem() == 6)
                                {
                                    personagem.sprite = personagem7;
                                }
                                else
                                {
                                    if (GameManager.Instance.getPersonagem() == 7)
                                    {
                                        personagem.sprite = personagem8;
                                    }
                                    else
                                    {
                                        if (GameManager.Instance.getPersonagem() == 8)
                                        {
                                            personagem.sprite = personagem9;
                                        }
                                        else
                                        {
                                            if (GameManager.Instance.getPersonagem() == 9)
                                            {
                                                personagem.sprite = personagem10;
                                            }
                                            else
                                            {
                                                if (GameManager.Instance.getPersonagem() == 10)
                                                {
                                                    personagem.sprite = personagem11;
                                                }
                                                else
                                                {
                                                    if (GameManager.Instance.getPersonagem() == 11)
                                                    {
                                                        personagem.sprite = personagem12;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
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
}
