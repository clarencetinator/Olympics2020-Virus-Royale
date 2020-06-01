using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Vector2 currentPositionY;
    Vector2 newPositionY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void CloseToPlayer()
    {

        currentPositionY = new Vector2(transform.position.x, transform.position.y);
        newPositionY = new Vector2(transform.position.x, transform.position.y + 1);

        transform.position = newPositionY;
    }



}
