using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private GameObject me;
    [SerializeField] private GameController game;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(me, 5f);

        //Finding the gameController of current scene
        game = FindObjectOfType<GameController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyMove();
        speed = 2f + game.LevelReturn();
    }

    public void enemyMove()
    {
        //making the enemy to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
        game.LevelReturn();
    }
}
