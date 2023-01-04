using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;  

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

     public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
     void OnCollisionEnter2D(Collision2D other)
    {
        
    
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
