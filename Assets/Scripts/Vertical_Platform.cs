using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical_Platform : MonoBehaviour
{
    private PlatformEffector2D effector;
   
    // Start is called before the first frame update
    void Start()
    {
        effector= GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
                effector.rotationalOffset= 180f;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0;
        }
    }
}
