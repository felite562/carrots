using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-6f, 6f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
          
        }
    }
}