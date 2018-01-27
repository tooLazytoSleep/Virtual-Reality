using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public GameObject Axis;//轴,用于选择围绕中心

    public float sRotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Vector3.down * sRotateSpeed, Space.World);
    }
}
