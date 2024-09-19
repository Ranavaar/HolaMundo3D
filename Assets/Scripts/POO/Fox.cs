using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        velocity = 7;
        maxEndurance = 37;
        endurance = maxEndurance;
        recovery = 6;
        timeRecovery = 15;
        tired = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (endurance > 1)
        {
            Run();
            print("El zorro esta corriendo");
        }
        if (endurance < 1)
        {
            Recovery();
            print("El zorro esta cansado");
        }
        print("El zorro lleva: " + meters + "metros");
    }
}
