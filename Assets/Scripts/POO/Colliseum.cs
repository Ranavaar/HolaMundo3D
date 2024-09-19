using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliseum : Circuit
{
    // Start is called before the first frame update
    void Start()
    {
        lenght = 350;
    }

    // Update is called once per frame
    void Update()
    {
        Position();
        Winer();
    }
}
