using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
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
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0; // Oyunu durdurma
        }
    }
}
