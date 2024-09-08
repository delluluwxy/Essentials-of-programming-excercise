using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    Vector3 scaleChange = new Vector3((float)0.002, (float)0.002, (float)0.001);
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
        transform.localScale += scaleChange;
    }
}
