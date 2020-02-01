using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapeadoMandoPs4 : MonoBehaviour
{

    




    void Update()
    {
        float setaHorizontalIzq = Input.GetAxis("JoyHorizontalIzq");
        float setaVerticalIzq = Input.GetAxis("JoyVerticalIzq");
        float setaHorizontalDrch = Input.GetAxis("JoyHorizontalDrch");
        float setaVerticalDrch = Input.GetAxis("JoyVerticalDrch");
        float analogico5 = Input.GetAxis("L2");
        float analogico6 = Input.GetAxis("R2");
        float flechaUp = Input.GetAxis("Horizontal");
        float flechaDown = Input.GetAxis("Vertical");



        //MAPEADO DE BOTONES


        if (Input.GetButtonDown("Cuadrado"))
        {
            Debug.Log("Has pulsado el boton CUADRADO. Button0");
        }
        if (Input.GetButtonDown("Equis"))
        {
            Debug.Log("Has pulsado el boton EQUIS. Button1");
        }
        if (Input.GetButtonDown("Circulo"))
        {
            Debug.Log("Has pulsado el boton CIRCULO. Button2");
        }
        if (Input.GetButtonDown("Triangulo"))
        {
            Debug.Log("Has pulsado el boton TRIANGULO. Button3");
        }
        if (Input.GetButtonDown("L1"))
        {
            Debug.Log("Has pulsado el boton L1. Button4");
        }
        if (Input.GetButtonDown("R1"))
        {
            Debug.Log("Has pulsado el boton R1. Button5");
        }
        if (analogico5 != 0)
        {
            Debug.Log("Has pulsado el boton L2. Button6 = " + analogico5);
        }
        if (analogico6 != 0)
        {
            Debug.Log("Has pulsado el boton R2. Button7 = " + analogico6);
        }
        if (Input.GetButtonDown("Share"))
        {
            Debug.Log("Has pulsado el boton SHARE. Button8");
        }
        if (Input.GetButtonDown("Options"))
        {
            Debug.Log("Has pulsado el boton OPTIONS. Button9");
        }
        if (Input.GetButtonDown("L3"))
        {
            Debug.Log("Has pulsado el boton L3. Button10");
        }
        if (Input.GetButtonDown("R3"))
        {
            Debug.Log("Has pulsado el boton R3. Button11");
        }
        if (Input.GetButtonDown("PsButton"))
        {
            Debug.Log("Has pulsado el boton BOTON PS. Button12");
        }
        if (Input.GetButtonDown("Tactil"))
        {
            Debug.Log("Has pulsado el boton BOTON TACTIL. Button13");
        }


        //MAPEADO DE PALANCAS


        


        if (setaHorizontalIzq != 0)
        {
            Debug.Log("Has pulsado el boton JOYSTICK IZQUIERDO HORIZONTAL X. Button14 = " + setaHorizontalIzq);
        }
        if (setaVerticalIzq != 0)
        {
            Debug.Log("Has pulsado el boton JOYSTICK IZQUIERDO VERTICAL Y. Button15 = " + setaVerticalIzq);
        }
        if (setaHorizontalDrch != 0)
        {
            Debug.Log("Has pulsado el boton  JOYSTICK DERECHO HORIZONTAL. Button16 = " + setaHorizontalDrch);
        }
        if (setaVerticalDrch != 0)
        {
            Debug.Log("Has pulsado el boton JOYSTICK DERECHO VERTICAL Y. Button17 = " + setaVerticalDrch);
        }
        if (flechaUp != 0)
        {
            Debug.Log("Has pulsado el boton DESCONOCIDO ARRIBA. Button18 = " + analogico5);
        }
        if (flechaDown != 0)
        {
            Debug.Log("Has pulsado el boton DESCONOCIDO ABAJO. Button19 = " + analogico6);
        }

    }
}
