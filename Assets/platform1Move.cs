using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform1Move : MonoBehaviour
{
    Vector3 rotateChange = new Vector3((float)0.01, (float)-0.01, (float)0.01);
    //public Vector3 scaleChange;
    //public Vector3 positionChange;
    //public Vector3 rotateChange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotateChange);
    }
}
