using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("Aw you hit an obstacle");
        enemy.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y + 1);
    }


}
