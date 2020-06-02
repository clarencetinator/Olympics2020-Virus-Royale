using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DeployHurdle : MonoBehaviour
{

    public GameObject hurdlePrefab;
    public float respawnTime = 1f;
    public Transform[] spawnPoint;


    

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(HurdleWave());
    }

    private void SpawnHurdles()
    {
        //Spawn Hurdles at a random position from the array
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
