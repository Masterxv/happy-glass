﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pump : MonoBehaviour {

    public GameObject Droplet;
    public int AmountOfWater;
    public UnityEvent Completed;
    // Use this for initialization
	IEnumerator xaNuocTuTu()
    {
        for (int i = 0; i < AmountOfWater; i++)
        {
            Instantiate(Droplet, transform.position + new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f)), Quaternion.identity, transform);
            yield return new WaitForSeconds(0.02f);
        }
        Completed.Invoke();
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0) && transform.childCount == 0)
        {
            StartCoroutine(xaNuocTuTu());
        }
    }
}
