using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

         if(Input.GetKeyDown(KeyCode.C))
         {
            Launch();
         }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 position = rigidbody2d.position;

        position.x = position.x + 20.0f * horizontal * Time.deltaTime;
        position.y = position.y + 20.0f * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    } 
    
 void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(new Vector2(0,1), 2000);

    }
    
    

}
