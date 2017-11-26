using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int personagem;
    public int score;

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
}

