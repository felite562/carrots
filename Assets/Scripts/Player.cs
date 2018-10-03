using System;
using UnityEngine;

public class Player : MonoBehaviour
{
	public GameObject bloodSplash;
    public GameObject restart;
    public static bool lose = false;
    public static bool catchBerry = false;
    public static int score;
    public static bool isPaused;
    
    
    public ParticleSystem explosion;
    void Awake()
    {
        lose = false;
        isPaused = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {   if (other.gameObject.tag == "berry") { catchBerry = true; score++;  Destroy(other.gameObject); }
        if (other.gameObject.tag == "bomb")
        { lose = true; 
			isPaused = false;
			Instantiate(explosion, transform.position, transform.rotation);
            restart.SetActive(true);  Destroy(other.gameObject); Destroy(gameObject);
           
           
            
            
        }
		if (Input.GetKey("escape"))
			Application.Quit();
    }

    

    
}
