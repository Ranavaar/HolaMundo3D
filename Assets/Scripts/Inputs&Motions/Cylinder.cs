using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public float speedRotate = 50;
    public float speed = 3;
    private Vector3 reset;
    // Start is called before the first frame update
    void Start()
    {
        reset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 3)
        transform.Translate(Vector3.right * -1 * speed * Time.deltaTime);
        //transform.Rotate(0, speedRotate * Time.deltaTime, 0);
        if (transform.position.y < 0)
            transform.position = reset;
    }
}
