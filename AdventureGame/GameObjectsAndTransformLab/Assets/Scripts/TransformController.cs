using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{

    public GameObject target;
    int distance = 3;
    float fastRotation = 70f;
    float slowRotation = 30f;


    void Update()
    {
        //Time.time returns a number that is increasing every frame, specifically the amount of time that has passed, in seconds, since the start of the program.
        var x = Mathf.PingPong(Time.time, distance);
        var p = new Vector3(-x, x, 0);
        target.transform.position = p;

        target.transform.Rotate(new Vector3(slowRotation, 0, fastRotation) * Time.deltaTime);
        
    }


}
