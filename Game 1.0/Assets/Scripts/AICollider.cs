using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICollider : MonoBehaviour
{
    public AI directionTrigger;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (directionTrigger.moveRight == false)
            directionTrigger.moveRight = true;
        else
            directionTrigger.moveRight = false;
    }
}
