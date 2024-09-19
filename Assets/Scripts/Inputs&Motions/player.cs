using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    //Public Attributes
    public float speed = 8;
    public float jump = 5;
    public float speedRotate = 100;
    public Rigidbody rb;
    public GameObject Target;
    public Transform cameraTransform;
    
    

    //Private Attributes

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * speedRotate * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
            rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
        if (Input.GetMouseButtonDown(0))
            Destroy(Target);

        cameraTransform.LookAt(transform.position);
    }
}
