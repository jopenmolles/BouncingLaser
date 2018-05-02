using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour {

    public GameObject laserObject;
    private bool _laserSpawned;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(SpatialUnderstanding.Instance.ScanState != SpatialUnderstanding.ScanStates.Done || _laserSpawned)
        {
            return;
        }

        Instantiate(laserObject);
        _laserSpawned = true;
	}
}
