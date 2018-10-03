using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Texture btnTexturePlay;
    public Texture btnTexturePause;
    public Rect btnPlay;
    public Texture btnTextureShop;
    public Rect btnShop;
    public Rect btnPause;
    public GUIStyle style;

    

    void Start()
    {
        Player.isPaused = false;
    }
    

    void OnGUI()
    {
        if (GUI.Button(btnShop, btnTextureShop, style))
        {
            Application.OpenURL("http://liqberry.com/");
        }

        if (!Player.isPaused)
        {

            //if (GUI.Button (btnPlay, btnTexturePlay, style)) {
            if (GUI.Button(btnPlay, btnTexturePlay, style))
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
