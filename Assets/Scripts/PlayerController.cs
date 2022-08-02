using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //creating we atributes.
    private Rigidbody2D rb;

    [SerializeField] private float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Getting my RigidBody
        rb = GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    void Update()
    {
        playerInput();
    }

    private void playerInput()
    {
        //Input Impulse
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //making the impulse velocity from rb;
            rb.velocity = Vector2.up * velocity;
        }

        if (rb.velocity.y < -velocity)
        {
            //sttoping rb.velocity.y in -5f;
            rb.velocity = Vector2.down * velocity;
        }
    }

}