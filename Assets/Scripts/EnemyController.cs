using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private GameObject me;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(me, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        enemyMove();
    }

    public void enemyMove()
    {
        //making the enemy to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
