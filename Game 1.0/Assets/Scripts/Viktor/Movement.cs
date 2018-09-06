using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float walkSpeed = 10f;

    private float horizontal;
    private float vertical;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(horizontal * walkSpeed, _rigidbody2D.velocity.y);
        switch (horizontal.ToString())
        {
            case "-1":
                transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                break;
            case "0":
                break;
            case "1":
                transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                break;
        }
    }

}
