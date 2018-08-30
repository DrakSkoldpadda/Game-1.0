using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.left;
    public bool moveRight = false;

    void FixedUpdate()
    {
        Movement();

        if (MovingDirection == Vector3.left)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        else if (MovingDirection == Vector3.right)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }

    void Movement()
    {
        if (moveRight == false)
            MovingDirection = Vector3.left;
        else if (moveRight == true)
            MovingDirection = Vector3.right;

        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
