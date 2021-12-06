using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI arrowKey;
    private string messageArrow;

    void Start()
    {
        messageArrow = "Pulsa cualquiera de las cuatro flechas";
        arrowKey.text = messageArrow;
    }

    void Update()
    {
        arrowKey.text = messageArrow;

        ShowMessage(messageArrow, KeyCode.RightArrow);
        ShowMessage(messageArrow, KeyCode.LeftArrow);
        ShowMessage(messageArrow, KeyCode.UpArrow);
        ShowMessage(messageArrow, KeyCode.DownArrow);
        ShowMessage(messageArrow, KeyCode.Space);
    }

    public void ShowMessage(string message, KeyCode key)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            messageArrow = "Derecha";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            messageArrow = "Izquierda";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            messageArrow = "Arriba";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            messageArrow = "Abajo";
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            messageArrow = "Pium!!";
        }

    }
}

