using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
        velocityLimit();
        LimitPlayer();

    }

    private void LimitPlayer()
    {
        var myPosition = transform.position.y;
        if (myPosition > 5.5 || myPosition < -5.5)
        {
            SceneManager.LoadScene("Jogo");
        }
    }

    private void playerInput()
    {
        //Input Impulse
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //making the impulse velocity from rb;
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void velocityLimit()
    {
        if (rb.velocity.y < -velocity)
        {
            //sttoping rb.velocity.y in -5f;
            rb.velocity = Vector2.down * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        SceneManager.LoadScene("Jogo");
    }
}
