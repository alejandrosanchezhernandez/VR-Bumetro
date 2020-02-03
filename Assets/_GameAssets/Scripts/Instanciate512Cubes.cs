﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciate512Cubes : MonoBehaviour
{
    public GameObject cubes;
    GameObject[] sampleCubes = new GameObject[512];
    public float maxScale;
    public float radio;
    public float gradosEntreBarras;

    void Start()
    {
        for(int i = 0; i < 512; i++)
        {
            GameObject instanceSampleCube = (GameObject)Instantiate(cubes);
            instanceSampleCube.transform.position = this.transform.position;
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube" + i;
            //this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            //this.transform.eulerAngles = new Vector3(0, -1f * i, 0);
            this.transform.eulerAngles = new Vector3(0, gradosEntreBarras * i, 0);
            instanceSampleCube.transform.position = Vector3.forward * radio;
            sampleCubes[i] = instanceSampleCube;

        }
    }

    void Update()
    {
        for (int i= 0; i < 512; i++)
        {
            if(sampleCubes != null)
            {
                sampleCubes[i].transform.localScale = new Vector3(10, (AudioPeer.samples[i]* maxScale) + 2, 10);
            }
        }
    }
}
