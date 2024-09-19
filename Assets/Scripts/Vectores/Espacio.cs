using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacio : MonoBehaviour
{
    //Public Attributes
    public Transform playerTransform;
    public Transform sphereTranform;
    //public Vector3 punto1 = new Vector3(5, 0, 0);
    public float speedX;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;

    //Private Attrivutes
    private float _rotatitonAngle;

    // Start is called before the first frame update
    void Start()
    {
        //playerTransform.position = punto1;
       
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento arcaico en 1 eje
        //playerTransform.position = punto1;
        //punto1 += Vector3.right * Time.deltaTime;

        // Movimiento en dos ejes
        playerTransform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);

        // Movimiento en dos ejes
        playerTransform.Translate(Vector3.right * speedX * Time.deltaTime);
        playerTransform.Translate(Vector3.up * speedY * Time.deltaTime);

        //Rotacion en un eje
        //playerTransform.Rotate(speedRotation * Time.deltaTime,0 ,0);
        playerTransform.Rotate(Vector3.forward * speedRotation * Time.deltaTime);

        //Rotate Around
        sphereTranform.RotateAround(playerTransform.position, Vector3.forward, _rotatitonAngle * Time.deltaTime * speedRotationSphere);
        _rotatitonAngle++;
    }
}
