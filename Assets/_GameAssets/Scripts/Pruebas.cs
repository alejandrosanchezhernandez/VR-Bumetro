using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    public float reloj;
    public float maximoContador = 3;
    public bool contando;

    void Start()
    {
        //ContadorDe3Segundos();
        Contador5Segundos();
    }

    void Update()
    {
        //Contador5Segundos();
        //ContadorDe3Segundos();
    }
    public void ContadorDe3Segundos()
    {

        while (reloj < maximoContador)
        {
            //reloj += Time.deltaTime;
            Debug.Log(reloj);
            ++reloj;
            //break;

        }
        
    }
    public void Contador5Segundos()
    {
        for(int monos =0; monos<20; monos++)
        {
            Debug.Log("Tengo: " + monos + " Chimpances");
            
        }
    }
}
