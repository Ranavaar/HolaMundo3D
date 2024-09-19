using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        velocity = 4;
        maxEndurance = 32;
        endurance = maxEndurance;
        recovery = 3;
        timeRecovery = 5;
        tired = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (endurance > 1)
        {
            Run();
            print("El conejo esta corriendo");
        }
        if (endurance < 1)
        {
            Recovery();
            print("El conejo esta cansado");
        }
        print("El conejo lleva: " + meters + "metros");
    }
}
