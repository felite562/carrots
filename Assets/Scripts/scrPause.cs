using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPause : MonoBehaviour {
	public Texture btnTexturePlay;
	public Texture btnTexturePause;
	public Texture btnTextureShop;
	public Rect btnShop;
	public Rect btnPause;
	public GUIStyle style;
	public Texture btnTextureScore;
	public Rect btnScore;
	public GUIStyle style1;

	// Use this for initialization
	void Start () {
		Player.isPaused = false;
	}
	
	void OnGUI()
	{   GUI.Button (btnScore, btnTextureScore, style1);
		if (Input.GetKey("escape"))
			Application.Quit();
		if (GUI.Button(btnShop, btnTextureShop, style))
		{
			Application.OpenURL("http://liqberry.lt/");
		}
		if (!Player.isPaused)
		{

			//if (GUI.Button (btnPlay, btnTexturePlay, style)) {
			if (GUI.Button(btnPause, btnTexturePlay, style))
			{
				Time.timeScale = 0f;
				Player.isPaused = true;
			}
		}
		if (Player.isPaused)
		{
			if (GUI.Button(btnPause, btnTexturePause, style))
			{
				Time.timeScale = 1.0f;
				Player.isPaused = false;
			}
		}
	}
}
