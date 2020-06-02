using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour
{

    public GameObject virus;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hurdle")
        {
            virus.transform.position = new Vector2(virus.transform.position.x, virus.transform.position.y - 0.5f);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Virus")
        {
            Debug.Log("You are now infected!");
            SceneManager.LoadScene("Game Over Scene");
        }
       
    }
}
