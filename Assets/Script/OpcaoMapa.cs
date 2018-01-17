using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcaoMapa : MonoBehaviour {

    public int opcao;

    public void mapa()
    {
        StartCoroutine("opcaoMapa");
    }

    IEnumerator opcaoMapa()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        if(opcao == 1)
        {
            SceneManager.LoadScene("Scene/hospital");
        }
        else
        {
            if (opcao == 2)
            {
                SceneManager.LoadScene("Scene/Casa");
            }
            else
            {
                if (opcao == 3)
                {
                    SceneManager.LoadScene("Scene/EscolaMasculino");
                }
                else
                {
                    if (opcao == 4)
                    {
                        SceneManager.LoadScene("Scene/Shopping");
                    }
                    else
                    {
                        if (opcao == 5)
                        {
                            SceneManager.LoadScene("Scene/Masp");
                        }
                        else
                        {
                            if (opcao == 6)
                            {
                                SceneManager.LoadScene("Scene/Farmacia");
                            }
                            else
                            {
                                if (opcao == 7)
                                {
                                    SceneManager.LoadScene("Scene/Lanchonete");
                                }
                                else
                                {
                                    if (opcao == 8)
                                    {
                                        SceneManager.LoadScene("Scene/EdificioMartinelli");
                                    }
                                    else
                                    {
                                        if (opcao == 9)
                                        {
                                            SceneManager.LoadScene("Scene/CasaAids");
                                        }
                                        else
                                        {
                                            if (opcao == 10)
                                            {
                                                SceneManager.LoadScene("Scene/Balada");
                                            }
                                            else
                                            {
                                                if (opcao == 11)
                                                {
                                                    SceneManager.LoadScene("Scene/PostoDeSaude2");
                                                }
                                                else
                                                {
                                                    if (opcao == 12)
                                                    {
                                                        SceneManager.LoadScene("Scene/Sorveteria");
                                                    }
                                                    else
                                                    {
                                                        if (opcao == 13)
                                                        {
                                                            SceneManager.LoadScene("Scene/escola_rosana");
                                                        }
                                                        else
                                                        {
                                                            if (opcao == 14)
                                                            {
                                                                SceneManager.LoadScene("Scene/Mercado");
                                                            }
                                                            else
                                                            {
                                                                if (opcao == 15)
                                                                {
                                                                    SceneManager.LoadScene("Scene/OscarNiemeyer");
                                                                }
                                                                else
                                                                {
                                                                    if (opcao == 16)
                                                                    {
                                                                        SceneManager.LoadScene("Scene/MonumentoBandeira");
                                                                    }
                                                                    else
                                                                    {
																		if (opcao == 17) {
																			SceneManager.LoadScene ("Scene/MonumentoIndependencia");
																		} else {
																			if (opcao == 18) {
																				SceneManager.LoadScene ("Scene/PostoDeSaude4");
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
                        }
                    }
                }
            }
        }
       
    }
}
