using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
 

    public GUIStyle styleScore;
    

        void OnGUI()
        {
            GUI.Label(new Rect(170, 20, 60, 60), "="+Player.score.ToString(), styleScore);
        }
    } 
