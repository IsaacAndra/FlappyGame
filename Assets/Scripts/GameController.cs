using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;

    [SerializeField] private GameObject enemy;
    [SerializeField] private Vector3 posicao;

    [SerializeField] private float posMin = -1.4f;
    [SerializeField] private float posMax = 1.1f;

    [SerializeField] private float intervalMin = 1f;
    [SerializeField] private float intervalMax = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += - Time.deltaTime;
        if(timer <= 0)
        {
            //Hello Whorld at 1sec
            Debug.Log("Hello World");
            timer = Random.Range(intervalMin, intervalMax);

            posicao.y = Random.Range(posMin, posMax);

            //creating the enemies
            Instantiate(enemy, posicao, Quaternion.identity);
        }
    }

    


}
