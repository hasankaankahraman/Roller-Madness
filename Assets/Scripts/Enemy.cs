using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Transform target;
    [SerializeField]  private float enemySpeed = 0f;
    [SerializeField] private float stopDistance = 1f;
    public bool gameover = false;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > stopDistance) 
        {
            transform.position += transform.forward * Time.deltaTime * enemySpeed; // düþmanýn oyuncuya mesafesini ayarladýk.
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            gameover = true;
            
        }
    }
}
