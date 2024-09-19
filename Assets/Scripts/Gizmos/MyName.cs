using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector2(0,0), new Vector2(2,2));
        Debug.DrawLine(new Vector2(2,2), new Vector2(4, 0));
        Debug.DrawLine(new Vector2(1, 1), new Vector2(3, 1));

        Debug.DrawLine(new Vector2(4, 0), new Vector2(6, 2));
        Debug.DrawLine(new Vector2(6, 2), new Vector2(8, 0));
        Debug.DrawLine(new Vector2(5, 1), new Vector2(7, 1));

        Debug.DrawLine(new Vector2(8, 0), new Vector2(8, 2));
        Debug.DrawLine(new Vector2(8, 2), new Vector2(10, 2));
        Debug.DrawLine(new Vector2(10, 2), new Vector2(10, 1));
        Debug.DrawLine(new Vector2(10, 1), new Vector2(8, 1));
        Debug.DrawLine(new Vector2(8, 1), new Vector2(10, 0));

        Debug.DrawLine(new Vector2(10.3f, 0), new Vector2(10.3f, 2));
        Debug.DrawLine(new Vector2(10.3f, 2), new Vector2(12.7f, 2));
        Debug.DrawLine(new Vector2(12.7f, 2), new Vector2(12.7f, 0));
        Debug.DrawLine(new Vector2(12.7f, 0), new Vector2(10.3f, 0));

        Debug.DrawLine(new Vector2(13, 0), new Vector2(13, 2));
        Debug.DrawLine(new Vector2(13, 2), new Vector2(15, 0));
        Debug.DrawLine(new Vector2(15, 0), new Vector2(15, 2));



    }
}
