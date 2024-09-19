using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Circuit : MonoBehaviour
{
    //Public Attributes
    public int lenght;
    public Circuit[] circuits;
    public Dog dog;
    public Rabbit rabbit;
    public Fox fox;    
    public City city;
    public Forest forest;
    public Colliseum colliseum;
   

    //Methods
    private void Start()
    {            
        print("Bienvenidos, la carrera esta a punto de comenzar");
        ChoseCircuit();        
    }
    private void Update()
    {       
      
    }

    public void ChoseCircuit()
    {
        int indexCircuits = Random.Range(0, 2);
        string[] optionCircuits = { "Forest", "City", "Colliseum" };
        string result = optionCircuits[indexCircuits];
        if (result == "Forest")
        {
            city.enabled = false;
            colliseum.enabled = false;
            print("El circuito es: " + result);
        }
        if (result == "City")
        {
            forest.enabled = false;
            colliseum.enabled = false;
            print("El circuito es: " + result);
        }
        if(result == "Colliseum")
        {
            forest.enabled = false;
            city.enabled = false;
            print("El circuito es: " + result);
        }
    }
    public void Position()
    {
        if (fox.meters > dog.meters)
        {
            if (fox.meters > rabbit.meters)
            {
                if(dog.meters > rabbit.meters)
                {
                    print("El Zorro va en primera posicion");
                    print("El Perro va en segunda posicion");
                    print("El Conejo va en tercera posicion");

                }
                else
                {
                    print("El Zorro va en primera posicion");
                    print("El Conejo va en segunda posicion");
                    print("El Perro va en tercera posicion");
                }
            }
            else
            {
                print("El Conejo va en primera posicion");
                print("El Zorro va en segunda posicion");
                print("El Perro va en tercera posicion");
            }
        }
        else
        {
            if(dog.meters > rabbit.meters)
            {
                if(fox.meters > rabbit.meters)
                {
                    print("El Perro va en primera posicion");             
                    print("El Zorro va en segunda posicion");             
                    print("El Conejo va en tercera posicion");             

                }
                else
                {
                    print("El Perro va en primera posicion");
                    print("El Conejo va en segunda posicion");
                    print("El Zorro va en tercera posicion");
                }
            }
            else
            {
                print("El Conejo va en primera posicion");
                print("El Perro va en segunda posicion");             
                print("El Zorro va en tercera posicion");
                

            }

        }
    }

    public void Winer()
    {
        if (lenght < dog.meters)
        {
            print("El ganador es el Perro");
            Time.timeScale = 0;
        }
        if (lenght < fox.meters)
        {
            print("El ganador es el Zorro");
            Time.timeScale = 0;
        }
        if (lenght < rabbit.meters)
        {
            print("El ganador es el conejo");
            Time.timeScale = 0;
        }
    }





}
