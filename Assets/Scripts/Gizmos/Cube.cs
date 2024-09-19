using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector2(17, 0), new Vector2(17, -2));
        Debug.DrawLine(new Vector2(17, -2), new Vector2(19, -2));
        Debug.DrawLine(new Vector2(19, -2), new Vector2(19, 0));
        Debug.DrawLine(new Vector2(19, 0), new Vector2(17, 0));

        Debug.DrawLine(new Vector2(17, 0), new Vector2(18, 1));
        Debug.DrawLine(new Vector2(17, -2), new Vector2(18, -1));
        Debug.DrawLine(new Vector2(19, -2), new Vector2(20, -1));
        Debug.DrawLine(new Vector2(19, 0), new Vector2(20, 1));

        Debug.DrawLine(new Vector2(18, 1), new Vector2(20, 1));
        Debug.DrawLine(new Vector2(20, 1), new Vector2(20, -1));
        Debug.DrawLine(new Vector2(20, -1), new Vector2(18, -1));
        Debug.DrawLine(new Vector2(18, -1), new Vector2(18, 1));
    }
}
