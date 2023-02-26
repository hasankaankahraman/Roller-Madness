using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    private bool iscollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (iscollided == false)
        {
            print(collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.black;
            Score scoreManager = FindObjectOfType<Score>();
            scoreManager.score--;
            iscollided= true;
        }

        /*if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0; // Oyunu durdurma
        }*/
    }
}
