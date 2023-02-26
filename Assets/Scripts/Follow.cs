using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float camfollowspeed = 5f; 



    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = Distance(target);// aradaki farký hesapladýk.
    }

    // Update is called once per frame
    void FixedUpdate() // Titremenin gitmesi için kullandýk. 
    {
        // transform.position = target.position +  offset;  // Farký hedef posizyona ekledik.
        MovetoCamera();
       
    }
    private void MovetoCamera()
    {
        Vector3 TargetoMove = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, TargetoMove, camfollowspeed * Time.deltaTime);
        transform.LookAt(target.transform.position);
    }
    private Vector3 Distance(Transform newTarget)
    {
        return transform.position - newTarget.position;
    }
}
