using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseLast : MonoBehaviour {
	

	public GameObject pauseBtn;
	public Material myTex;

	public void onPause() {
		

		Time.timeScale = 0f;
		Player.isPaused = true;

	}
	public void onUnPause() {
		Time.timeScale = 1.0f;
		Player.isPaused = false;


	}

	}