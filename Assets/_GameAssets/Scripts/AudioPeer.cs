using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{
    public AudioSource audioSource;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        GetSpectrumAudioSource();
        RetocarFreq();
    
    }
    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
        
    }
    void RetocarFreq()
    {
        int contador = 0;

        for(int i  = 0; i < 8; i++)
        {
            float promedio = 0;
            int contadorDeSamples = (int)Mathf.Pow(2, i) * 2;

            if(i == 7)
            {
                contadorDeSamples += 2;
            }
            for(int j = 0; j < contadorDeSamples; j++)
            {
                promedio += samples[contador] * (contador + 1);
                contador++;
            }
            promedio /= contador;
            freqBand[i] = promedio * 10;
        }
        

    }
}
