using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int personagem;
    public int score;
    public int convite;

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
}

