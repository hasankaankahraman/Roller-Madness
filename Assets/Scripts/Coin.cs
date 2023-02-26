using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float yMin = 1f;
    public float yMax = 4f;
    public float speed = 1f;


    void Update()
    {
        float y = transform.position.y + speed * Time.deltaTime;
        if (y > yMax || y < yMin)
        {
            speed = -speed;
        }
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }

}