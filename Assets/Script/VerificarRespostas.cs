using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarRespostas : MonoBehaviour {

    public GameObject Pergunta1;
    public GameObject Pergunta2;
    public GameObject Pergunta3;
    public GameObject Pergunta4;
    public GameObject Pergunta5;
    public GameObject Pergunta6;
    public GameObject Pergunta7;
    public GameObject Pergunta8;
    public GameObject Pergunta9;
    public GameObject Pergunta10;
    public GameObject Cena1;
    public GameObject CenaFinal;
    public GameObject CenaRespostaIndicacao;
    public GameObject CenaRespostaMedica;
    public GameObject CenaRespostaMetodo;
    public GameObject CenaRespostaCamisinha;
    public GameObject CenaRespostaDiafragma;
    public GameObject CenaRespostaPilulaAnticoncepcional;
    public GameObject CenaRespostaPilulaDiaSeguinte;
    public GameObject CenaRespostaInjecaoAnticoncepcional;
    public GameObject CenaRespostaMinipilula;

    // Use this for initialization
    void Start () {
        cenaInicio();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cenaInicio()
    {
        GameManager.Instance.zerarQuestionario();
        Cena1.SetActive(true);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta1()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(true);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void final()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(true);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta2()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(true);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta3()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(true);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta4()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(true);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta5()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(true);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta6()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(true);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta7()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(true);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta8()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(true);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta9()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(true);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void pergunta10()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(true);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaIndicacao()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(true);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaMedica()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(true);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaMetodo()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(true);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaCamisinha()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(true);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaDiafragma()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(true);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaPilulaAnticoncepcional()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(true);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaPilulaDiaSeguinte()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(true);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaInjecaoAnticoncepcional()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(true);
        CenaRespostaMinipilula.SetActive(false);
    }

    public void cenaRespostaMinipilula()
    {
        Cena1.SetActive(false);
        Pergunta1.SetActive(false);
        Pergunta2.SetActive(false);
        Pergunta3.SetActive(false);
        Pergunta4.SetActive(false);
        Pergunta5.SetActive(false);
        Pergunta6.SetActive(false);
        Pergunta7.SetActive(false);
        Pergunta8.SetActive(false);
        Pergunta9.SetActive(false);
        Pergunta10.SetActive(false);
        CenaFinal.SetActive(false);
        CenaRespostaIndicacao.SetActive(false);
        CenaRespostaMedica.SetActive(false);
        CenaRespostaMetodo.SetActive(false);
        CenaRespostaCamisinha.SetActive(false);
        CenaRespostaDiafragma.SetActive(false);
        CenaRespostaPilulaAnticoncepcional.SetActive(false);
        CenaRespostaPilulaDiaSeguinte.SetActive(false);
        CenaRespostaInjecaoAnticoncepcional.SetActive(false);
        CenaRespostaMinipilula.SetActive(true);
    }

    public void perguntaAnteriorRespostaIndicacao()
    {
        GameManager.Instance.responderPergunta(4, 0);
        pergunta4();
    }

    public void perguntaAnterior2()
    {
        GameManager.Instance.responderPergunta(1, 0);
        pergunta1();
    }

    public void perguntaAnterior3()
    {
        GameManager.Instance.responderPergunta(2, 0);
        pergunta2();
    }

    public void perguntaAnterior4()
    {
        GameManager.Instance.responderPergunta(3, 0);
        pergunta3();
    }

    public void perguntaAnterior5()
    {
        if(GameManager.Instance.pergunta1 == 1)
        {
            if ((GameManager.Instance.pergunta3 == 3) ||
                (GameManager.Instance.pergunta3 == 4))
            {
                GameManager.Instance.responderPergunta(3, 0);
                pergunta3();
            }
            else
            {
                GameManager.Instance.responderPergunta(4, 0);
                pergunta4();
            }
        } else
        {
            if (GameManager.Instance.pergunta1 == 2)
            {
                if ((GameManager.Instance.pergunta3 == 1) ||
                (GameManager.Instance.pergunta3 == 2) ||
                (GameManager.Instance.pergunta3 == 3) ||
                (GameManager.Instance.pergunta3 == 4))
                {
                    GameManager.Instance.responderPergunta(3, 0);
                    pergunta3();
                }
                else
                {
                    GameManager.Instance.responderPergunta(4, 0);
                    pergunta4();
                }
            } else
            {
                GameManager.Instance.responderPergunta(3, 0);
                pergunta3();
            }
        }
    }

    public void perguntaAnterior6()
    {
        if (GameManager.Instance.pergunta1 == 1)
        {
            if (GameManager.Instance.pergunta5 == 1)
            {
                GameManager.Instance.responderPergunta(5, 0);
                pergunta5();
            }
            else
            {
                if (GameManager.Instance.pergunta3 == 6)
                {
                    GameManager.Instance.responderPergunta(3, 0);
                    pergunta3();
                }
                else
                {
                    if(GameManager.Instance.pergunta2 == 2)
                    {
                        GameManager.Instance.responderPergunta(2, 0);
                        pergunta2();
                    }
                    else
                    {
                        cenaRespostaIndicacao();
                    }    
                }
            }
        }
        else
        {
            if (GameManager.Instance.pergunta1 == 2)
            {
                if (GameManager.Instance.pergunta5 == 1)
                {
                    GameManager.Instance.responderPergunta(5, 0);
                    pergunta5();
                }
                else
                {
                    if (GameManager.Instance.pergunta3 == 6)
                    {
                        GameManager.Instance.responderPergunta(3, 0);
                        pergunta3();
                    }
                    else
                    {
                        if (GameManager.Instance.pergunta2 == 2)
                        {
                            GameManager.Instance.responderPergunta(2, 0);
                            pergunta2();
                        }
                        else
                        {
                            cenaRespostaIndicacao();
                        }
                    }
                }
            }
            else
            {
                if (GameManager.Instance.pergunta5 == 1)
                {
                    GameManager.Instance.responderPergunta(5, 0);
                    pergunta5();
                }
                else
                {
                    if (GameManager.Instance.pergunta3 == 6)
                    {
                        GameManager.Instance.responderPergunta(3, 0);
                        pergunta3();
                    }
                    else
                    {
                        cenaRespostaIndicacao();
                    }
                }
            }
        }
    }

    public void perguntaAnterior7()
    {
        GameManager.Instance.responderPergunta(6, 0);
        pergunta6();
    }

    public void perguntaAnterior8()
    {
        if(GameManager.Instance.pergunta1 == 1)
        {
            if(GameManager.Instance.pergunta6 == 5)
            {
                GameManager.Instance.responderPergunta(6, 0);
                pergunta6();
            }
            else
            {
                GameManager.Instance.responderPergunta(7, 0);
                pergunta7();
            }
        }
        else
        {
            GameManager.Instance.responderPergunta(6, 0);
            pergunta6();
        }
    }

    public void perguntaAnterior9()
    {
        GameManager.Instance.responderPergunta(7, 0);
        pergunta7();
    }

    public void perguntaAnterior10()
    {
        if ((GameManager.Instance.pergunta7 == 1) || (GameManager.Instance.pergunta7 == 3))
        {
            GameManager.Instance.responderPergunta(7, 0);
            pergunta7();
        }
        else
        {
            GameManager.Instance.responderPergunta(9, 0);
            pergunta9();
        }
    }

    public void proximaPergunta1Resposta1()
    {
        GameManager.Instance.responderPergunta(1, 1);
        pergunta2();
    }

    public void proximaPergunta1Resposta2()
    {
        GameManager.Instance.responderPergunta(1, 2);
        pergunta2();
    }

    public void proximaPergunta1Resposta3()
    {
        GameManager.Instance.responderPergunta(1, 3);
        pergunta2();
    }

    public void proximaPergunta2Resposta1()
    {
        GameManager.Instance.responderPergunta(2, 1);
        pergunta3();
    }

    public void proximaPergunta2Resposta2()
    {
        GameManager.Instance.responderPergunta(2, 2);
        pergunta6();
    }

    public void proximaPergunta2Resposta3()
    {
        GameManager.Instance.responderPergunta(2, 3);
        cenaRespostaMetodo();
    }

    public void proximaPergunta3Resposta1()
    {
        GameManager.Instance.responderPergunta(3, 1);
        if(GameManager.Instance.pergunta1 == 1)
        {
            pergunta4();
        } else
        {
            pergunta5();
        }
    }

    public void proximaPergunta3Resposta2()
    {
        GameManager.Instance.responderPergunta(3, 2);
        if (GameManager.Instance.pergunta1 == 1)
        {
            pergunta4();
        }
        else
        {
            pergunta5();
        }
    }

    public void proximaPergunta3Resposta3()
    {
        GameManager.Instance.responderPergunta(3, 3);
        pergunta5();
    }

    public void proximaPergunta3Resposta4()
    {
        GameManager.Instance.responderPergunta(3, 4);
        pergunta5();
    }

    public void proximaPergunta3Resposta5()
    {
        GameManager.Instance.responderPergunta(3, 5);
        if (GameManager.Instance.pergunta1 == 3)
        {
            pergunta5();
        }
        else
        {
            pergunta4();
        }
    }

    public void proximaPergunta3Resposta6()
    {
        GameManager.Instance.responderPergunta(3, 6);
        pergunta6();
    }

    public void proximaPergunta4Resposta1()
    {
        GameManager.Instance.responderPergunta(4, 1);
        pergunta5();
    }

    public void proximaPergunta4Resposta2()
    {
        GameManager.Instance.responderPergunta(4, 2);
        cenaRespostaIndicacao();
    }

    public void proximaPergunta5Resposta1()
    {
        GameManager.Instance.responderPergunta(5, 1);
        pergunta6();
    }

    public void proximaPergunta5Resposta2()
    {
        GameManager.Instance.responderPergunta(5, 2);
        cenaRespostaMetodo();
    }

    public void proximaPergunta5Resposta3()
    {
        GameManager.Instance.responderPergunta(5, 3);
        cenaRespostaMedica();
    }

    public void proximaPergunta6Resposta1()
    {
        GameManager.Instance.responderPergunta(6, 1);
        pergunta7();
    }

    public void proximaPergunta6Resposta2()
    {
        GameManager.Instance.responderPergunta(6, 2);
        cenaRespostaCamisinha();
    }

    public void proximaPergunta6Resposta3()
    {
        GameManager.Instance.responderPergunta(6, 3);
        cenaRespostaPilulaAnticoncepcional();
    }

    public void proximaPergunta6Resposta4()
    {
        GameManager.Instance.responderPergunta(6, 4);
        cenaRespostaPilulaDiaSeguinte();
    }

    public void proximaPergunta6Resposta5()
    {
        GameManager.Instance.responderPergunta(6, 5);
        pergunta8();
    }

    public void proximaPergunta7Resposta1()
    {
        if (GameManager.Instance.pergunta1 == 1)
        {
            GameManager.Instance.responderPergunta(7, 1);
            pergunta8();
        } else
        {
            GameManager.Instance.responderPergunta(7, 1);
            pergunta10();
        }
    }

    public void proximaPergunta7Resposta2()
    {
        if (GameManager.Instance.pergunta1 == 1)
        {
            GameManager.Instance.responderPergunta(7, 2);
            pergunta8();
        }
        else
        {
            GameManager.Instance.responderPergunta(7, 2);
            cenaRespostaDiafragma();
        }
    }

    public void proximaPergunta7Resposta3()
    {
        if (GameManager.Instance.pergunta1 == 1)
        {
            GameManager.Instance.responderPergunta(7, 3);
            cenaRespostaPilulaAnticoncepcional();
        }
        else
        {
            GameManager.Instance.responderPergunta(7, 3);
            pergunta10();
        }      
    }

    public void proximaPergunta7Resposta4()
    {
        GameManager.Instance.responderPergunta(7, 4);
        cenaRespostaCamisinha();
    }

    public void proximaPergunta7Resposta5()
    {
        GameManager.Instance.responderPergunta(7, 5);
        pergunta9();
    }

    public void proximaPergunta8Resposta1()
    {
        GameManager.Instance.responderPergunta(8, 1);
        cenaRespostaCamisinha();
    }

    public void proximaPergunta8Resposta2()
    {
        GameManager.Instance.responderPergunta(8, 2);
        cenaRespostaDiafragma();
    }

    public void proximaPergunta9Resposta1()
    {
        if(GameManager.Instance.pergunta1 == 1)
        {
            GameManager.Instance.responderPergunta(9, 1);
            cenaRespostaCamisinha();
        } else
        {
            GameManager.Instance.responderPergunta(9, 1);
            pergunta10();
        }
    }

    public void proximaPergunta9Resposta2()
    {
        if (GameManager.Instance.pergunta1 == 1)
        {
            GameManager.Instance.responderPergunta(9, 2);
            cenaRespostaPilulaAnticoncepcional();
        }
        else
        {
            GameManager.Instance.responderPergunta(9, 2);
            pergunta10();
        }
    }

    public void proximaPergunta10Resposta1()
    {
        GameManager.Instance.responderPergunta(10, 1);
        cenaRespostaInjecaoAnticoncepcional();
    }

    public void proximaPergunta10Resposta2()
    {
        if (GameManager.Instance.pergunta9 == 1)
        {
            GameManager.Instance.responderPergunta(10, 2);
            cenaRespostaCamisinha();
        }
        else
        {
            GameManager.Instance.responderPergunta(10, 2);
            cenaRespostaPilulaAnticoncepcional();
        }
    }
}
