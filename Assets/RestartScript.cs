using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {
    public Pathmaker pathmaker;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pathmaker.totalMax = 0;
		if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
	}
}
