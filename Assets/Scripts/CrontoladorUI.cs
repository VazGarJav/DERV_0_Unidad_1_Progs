using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CrontoladorUI : MonoBehaviour
{
    public TextMeshProUGUI texto;

    public void saludar()
    {
        texto.text = "Hola amigo :D!!";
    }
}
