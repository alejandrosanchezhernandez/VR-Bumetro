using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroscopioCamara : MonoBehaviour
{
    public GameObject camaraVr;
    public bool seIniciJuego;

    private float posInicialY = 0f;
    private float posInicialGiroY = 0f;
    private float calibrarPosY = 0f;

    void Start()
    {
        Input.gyro.enabled = true;
        posInicialY = camaraVr.transform.eulerAngles.y;
    }

    void Update()
    {
        AplicarRotacionGiroscopio();
        AplicarCalibracion();

        if(seIniciJuego == true)
        {
            Invoke("CalibrarPosicionY", 3f);
            seIniciJuego = false;
        }
    }

    void AplicarRotacionGiroscopio()
    {
        camaraVr.transform.rotation = Input.gyro.attitude;
        camaraVr.transform.Rotate(0f, 0f, 180f, Space.Self);
        camaraVr.transform.Rotate(90f, 180f, 0f, Space.World);
        posInicialGiroY = camaraVr.transform.eulerAngles.y;
    }

    void CalibrarPosicionY()
    {
        calibrarPosY = posInicialGiroY - posInicialY;
    }

    void AplicarCalibracion()
    {
        camaraVr.transform.Rotate(0f, -calibrarPosY, 0f, Space.World);
    }
}
