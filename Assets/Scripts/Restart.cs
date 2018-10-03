using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   

    void OnMouseDown()
    {
        Player.score = 0;
        SceneManager.LoadScene("main");
		if (Input.GetKey("escape"))
			Application.Quit();
    }
}