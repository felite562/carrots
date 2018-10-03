using System.Collections;
using UnityEngine;

public class SpawnBerry : MonoBehaviour {

    public GameObject berry;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(berry, new Vector2(Random.Range(-9f, 9f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1.2f);

        }
    }
}
