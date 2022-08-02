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
            Debug.Log("Oi");
            timer = 1f;

            posicao.y = Random.Range(posMin, posMax);

            //creating the enemies
            Instantiate(enemy, posicao, Quaternion.identity);
        }
    }

    //Hello Whorld at 1sec


}
