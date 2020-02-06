using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciate512Cubes : MonoBehaviour
{
    public GameObject cubes;
    GameObject[] sampleCubes = new GameObject[45];
    public float maxScale;
    public float radio;
    public float gradosEntreBarras;
    public float sensibilidadVertical;
    public float profundidadBumetros;
    public float anchoBumetros;

    void Start()
    {
        for(int i = 0; i < 45; i++)
        {
            GameObject instanceSampleCube = (GameObject)Instantiate(cubes);
            instanceSampleCube.transform.position = this.transform.position;
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, gradosEntreBarras * i, 0);
            instanceSampleCube.transform.position = Vector3.forward * radio;
            sampleCubes[i] = instanceSampleCube;

        }
    }

    void Update()
    {
        for (int i= 0; i < 45; i++)
        {
            if(sampleCubes != null)
            {
                //sampleCubes[i].transform.localScale = new Vector3(10, (AudioPeer.samples[i]* maxScale) + 2, 10);
                //sampleCubes[i].transform.localScale = new Vector3(anchoBumetros, (AudioPeer.samples[i] * maxScale) + sensibilidadVertical, profundidadBumetros);
                sampleCubes[i].transform.localScale = new Vector3(anchoBumetros, (2 * AudioPeer.samples[i] * maxScale)+ sensibilidadVertical, profundidadBumetros);
            }
        }
    }
}
