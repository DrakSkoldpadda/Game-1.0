using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimtarget : MonoBehaviour
{
    public Vector3 TargetPos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TargetPos.z = 0;
        GetComponent<Transform>().position = TargetPos;
    }
}
