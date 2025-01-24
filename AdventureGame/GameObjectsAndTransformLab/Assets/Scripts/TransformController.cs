using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{

    public GameObject target;


    void Update()
    {
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        target.transform.position = p;

        target.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
