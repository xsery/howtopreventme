using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int personagem;
    public int score;
    public int convite;

    //questionario
    public int pergunta1;
    public int pergunta2;
    public int pergunta3;
    public int pergunta4;
    public int pergunta5;
    public int pergunta6;
    public int pergunta7;
    public int pergunta8;
    public int pergunta9;
    public int pergunta10;
    public int resposta;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameManager";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int consultarPersonagem()
    {
        return personagem;
    }

    public void buttonRight()
    {
        if (personagem < 11)
        {
            personagem++;
        }
        else
        {
            personagem = 0;
        }     
    }

    public void buttonLeft()
    {
        if (personagem > 0)
        {
            personagem--;
        }
        else
        {
            personagem = 11;
        }
    }

    public void aceitarConvite()
    {
        convite = 1;
    }

    public void recusarConvite()
    {
        convite = 0;
    }

    public void ganhaUmPonto()
    {
        score = score + 1;
    }

    public int verificarConvite()
    {
        return convite;
    }

    public void ganhaCincoPonto()
    {
        score = score + 5;
    }

    public void diminuiDoisPonto()
    {
        if(score > 2)
            score = score - 2;
    }

    public void diminuiUmPonto()
    {
        if (score > 1)
            score = score - 1;
    }

    public void diminuiTresPonto()
    {
        if (score > 3)
        {
            score = score - 3;
        }
    }

    public string getScoreText()
    {
        return score.ToString();
    }

    public int getPersonagem()
    {
        return personagem;
    }

    public void zerarQuestionario()
    {
        pergunta1 = 0;
        pergunta2 = 0;
        pergunta3 = 0;
        pergunta4 = 0;
        pergunta5 = 0;
        pergunta6 = 0;
        pergunta7 = 0;
        pergunta8 = 0;
        pergunta9 = 0;
        pergunta10 = 0;
    }

    public void responderPergunta(int pergunta, int respostas)
    {
        if (pergunta == 1)
        {
            pergunta1 = respostas;
        }
        else
        {
            if (pergunta == 2)
            {
                pergunta2 = respostas;
            }
            else
            {
                if (pergunta == 3)
                {
                    pergunta3 = respostas;
                }
                else
                {
                    if (pergunta == 4)
                    {
                        pergunta4 = respostas;
                    }
                    else
                    {
                        if (pergunta == 5)
                        {
                            pergunta5 = respostas;
                        }
                        else
                        {
                            if (pergunta == 6)
                            {
                                pergunta6 = respostas;
                            }
                            else
                            {
                                if (pergunta == 7)
                                {
                                    pergunta7 = respostas;
                                }
                                else
                                {
                                    if (pergunta == 8)
                                    {
                                        pergunta8 = respostas;
                                    }
                                    else
                                    {
                                        if (pergunta == 9)
                                        {
                                            pergunta9 = respostas;
                                        }
                                        else
                                        {
                                            if (pergunta == 10)
                                            {
                                                pergunta10 = respostas;
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

    public int verificarRespostaPergunta(int pergunta)
    {

        

        if (pergunta == 1)
        {
            resposta = pergunta1;
        }
        else
        {
            if (pergunta == 2)
            {
                resposta = pergunta2;
            }
            else
            {
                if (pergunta == 3)
                {
                    resposta = pergunta3;
                }
                else
                {
                    if (pergunta == 4)
                    {
                        resposta = pergunta4;
                    }
                    else
                    {
                        if (pergunta == 5)
                        {
                            resposta = pergunta5;
                        }
                        else
                        {
                            if (pergunta == 6)
                            {
                                resposta = pergunta6;
                            }
                            else
                            {
                                if (pergunta == 7)
                                {
                                    resposta = pergunta7;
                                }
                                else
                                {
                                    if (pergunta == 8)
                                    {
                                        resposta = pergunta8;
                                    }
                                    else
                                    {
                                        if (pergunta == 9)
                                        {
                                            resposta = pergunta9;
                                        }
                                        else
                                        {
                                            if (pergunta == 10)
                                            {
                                                resposta = pergunta10;
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

        return resposta;
    }
}

