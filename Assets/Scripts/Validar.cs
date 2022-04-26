using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validar : MonoBehaviour
{
    string contracorrecta;
    string contrausuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelMsj;
    // Start is called before the first frame update
    void Start()
    {
        contracorrecta = "12345";
        cartelMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarcontra()
    {
        contrausuario = ingresoUsuario.text;
        if (contrausuario == contracorrecta)
        {
            cartelMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelMsj.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
