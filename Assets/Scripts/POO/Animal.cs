using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //Public Attributes
    public Animal[] animal;
    public float velocity;
    public float endurance;
    public float maxEndurance;
    public float meters;
    public float recovery;
    public float timeRecovery;
    public float tired;


    //Methods

    public void Run()
    {
        meters += velocity * Time.deltaTime;
        endurance = endurance - 1 * Time.deltaTime;
        recovery = timeRecovery;

    }
    public void Recovery()
    {
        if (endurance < 1)
        {
            endurance = 0;            
            recovery = recovery - 1 * Time.deltaTime;
            meters += tired * Time.deltaTime;
        }      
        if (recovery < 0)
        {
            endurance = maxEndurance;
        }
    }


}
