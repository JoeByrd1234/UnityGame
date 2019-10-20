using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour {
    int currentFrame;

	// Use this for initialization
	void Start () {
		Debug.Log("I am being run when the Game Master is intialized!");
        currentFrame = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentFrame++;
		Debug.Log("I am being logged every frame. Current Frame: " + currentFrame);
	}
}
