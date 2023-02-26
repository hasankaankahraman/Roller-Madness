using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]private Vector3 movement;
    [SerializeField]private new Rigidbody rigidbody;
    public int speed;

    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovetoPlayer();
    }


    private void MovetoPlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        movement = new Vector3(x, 0f, z);
        //transform.position += movement;
        rigidbody.AddForce(movement);

    }
}
