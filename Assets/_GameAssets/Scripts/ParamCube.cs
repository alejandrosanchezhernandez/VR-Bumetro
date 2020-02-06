using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int band;
    public float escalaInicial, multiplicadorEscala;


    void Start()
    {
        
    }

    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (AudioPeer.freqBand[band] * multiplicadorEscala) + escalaInicial, transform.localScale.z); 
    }
}
