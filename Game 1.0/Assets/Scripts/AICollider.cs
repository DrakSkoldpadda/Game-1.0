using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICollider : MonoBehaviour
{
    public AI AIVariables;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            if (AIVariables.moveRight == false)
                AIVariables.moveRight = true;
            else
                AIVariables.moveRight = false;
        }

        //if (collision.gameObject.CompareTag("Projectile"))
        //{
        //    AIVariables.AIHP -=
        //}
    }
}
