using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarCompras : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pts()
    {
        GameManager.Instance.diminuiDoisPonto();
    }

    public void Chapeupts()
    {
        GameManager.Instance.diminuiTresPonto();
    }

    public void vlpts()
    {
        if (GameManager.Instance.score > 0)
        {
            GameManager.Instance.diminuiUmPonto();
            gameObject.SetActive(false);
        }
    }
}
