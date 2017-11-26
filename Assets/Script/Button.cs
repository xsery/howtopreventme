using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public void buttonLeft()
    {
        GameManager.Instance.buttonLeft();
    }

    public void buttonRight()
    {
        GameManager.Instance.buttonRight();
    }
}
