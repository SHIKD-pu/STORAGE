﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<ParticleSystem>().Play();
		Debug.Log(GetComponent<ParticleSystem>());
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
