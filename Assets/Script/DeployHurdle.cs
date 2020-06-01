using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployHurdle : MonoBehaviour
{

    public GameObject hurdlePrefab;
    public float respawnTime = 1.0f;
    public Transform[] spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(HurdleWave());
    }

    private void SpawnHurdles()
    {
        GameObject a = Instantiate(hurdlePrefab, spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity) as GameObject;
        //a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * -2);
    }

    IEnumerator HurdleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnHurdles();
        }
        

    }
    
}
