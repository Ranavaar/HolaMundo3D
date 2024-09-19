using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    
    // Start is called before the first frame update
    void Start()
    {
        velocity = 6;
        maxEndurance = 40;
        endurance = maxEndurance;
        recovery = 7;
        timeRecovery = 12;
        tired = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (endurance > 1)
        {
            Run();
            print("El perro esta corriendo");
        }
        if (endurance < 1)
        {
            Recovery();
            print("El perro esta cansado");
        }
        print("El perro lleva: " + meters + "metros");
    }
}
