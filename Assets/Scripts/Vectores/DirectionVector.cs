using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //Public Attributes
    public Transform initialPos;
    public Transform finalPos;
    public float speed = 3;

    //Private Attributes
    private Vector3 _directionVector;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _directionVector = finalPos.position - initialPos.position;
        _directionVector.Normalize();

        Debug.DrawRay(initialPos.position, _directionVector);

        initialPos.Translate(_directionVector * Time.deltaTime * speed);

        print(_directionVector.magnitude * speed);

        float distance = Vector3.Distance(initialPos.position, finalPos.position);
        print("Distancia: " + distance);

        if (distance < 10)
            speed *= -1;

        if (distance > 20)
            speed *= -1;
    }
}
