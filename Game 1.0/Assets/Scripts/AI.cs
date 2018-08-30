using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    //AI name = Lil boii

    [Header("MovingAtributes (DON'T TOUCH!)")]
    public bool moveRight = false;
    private Vector3 MovingDirection = Vector3.left;
    private float moveSpeed = 10f;

    [Header("HealthAtributes (DON'T TOUCH!)")]
    public int AIHP = 5;

    void FixedUpdate()
    {
        Movement();

        Health();
    }

    void Health()
    {

        if (AIHP <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Movement()
    {
        //Åt vilket håll Lil boii ska röra sig åt
        if (moveRight == false)
            MovingDirection = Vector3.left;
        else if (moveRight == true)
            MovingDirection = Vector3.right;

        //Bestämmer åt vilket håll Lil Boii ska kolla åt, checkas med åt vilket håll Lil boii går åt
        if (MovingDirection == Vector3.left)
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        else if (MovingDirection == Vector3.right)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        //Hur snabb Lil boii är
        this.transform.Translate(MovingDirection * moveSpeed * Time.smoothDeltaTime);
    }
}
