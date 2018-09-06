using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector2 mousePos;
    public GameObject Projectile;
    public float resetCooldown = 1f;
    private float cooldown;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        cooldown -= Time.deltaTime;

        // The projektile for the ranged attacks
        GameObject newProjectile;


        mousePos = Input.mousePosition;
        Vector3 MouseWorldPos;

        // finds the mouse location inside the camera
        MouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 differens;
        differens = MouseWorldPos - transform.position;
        differens.Normalize();

        if (Input.GetMouseButtonDown(0))
        {
            if (cooldown <= 0)
            {
                newProjectile = Instantiate(Projectile, transform.position, Quaternion.identity);

                newProjectile.GetComponent<Rigidbody2D>().AddForce(differens * 20, ForceMode2D.Impulse);
                cooldown = resetCooldown;
                Physics2D.IgnoreCollision(newProjectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }
    }
}
