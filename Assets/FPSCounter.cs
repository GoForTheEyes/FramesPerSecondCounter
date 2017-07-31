using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour {

    public int FPS { get; private set; }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //we used unscaledDeltaTime instead of deltaTime in case the time scale of the unity editor is not 1s 
        FPS = (int)(1f / Time.unscaledDeltaTime);
	}
}
