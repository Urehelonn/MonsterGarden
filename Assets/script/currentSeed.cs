using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentSeed : MonoBehaviour {
    public Seed[] plants;
    
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 16; i++)
        {
            plants[i] = new Seed();
        }
	}
}
