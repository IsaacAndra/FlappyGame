using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{


    [SerializeField] private float timer = 1f;

    [SerializeField] private GameObject enemy;
    [SerializeField] private AudioClip soundLevel;
    [SerializeField] private Vector3 posicao;
    [SerializeField] private Vector3 camPos;

    //Variables of y direction
    [SerializeField] private float posMin = -1.4f;
    [SerializeField] private float posMax = 1.1f;

    //Variables of x direction
    [SerializeField] private float intervalMin = 1f;
    [SerializeField] private float intervalMax = 1.5f;

    //Score Variables
    [SerializeField] private Text scoreText;
    private float score = 0;

    //Variable of level
    private int level = 1;
    [SerializeField] private Text levelText;


    //Variable for take more level
    [SerializeField] private float nextLevel = 10f;

    // Start is called before the first frame update
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GenerateEnemy();
        gameScore();
        LevelUpdate();
        
    }

    //creating score
    private void gameScore()
    {
        score += Time.deltaTime * level;
        
        scoreText.text ="Time Score " + Mathf.Round(score).ToString();
        
    }

    //ganing level
    private void LevelUpdate()
    {
        if(score > nextLevel)
        {

            //soundLevel
            AudioSource.PlayClipAtPoint(soundLevel, camPos, 0.5f);

            //Increase the level in 1
            level++;
            //Doubling the next level value
            nextLevel *= 2;                     
        }

        //Level in Canvas
        levelText.text = "Lv " + level.ToString();

    }


    //Procedural Enemy
    public void GenerateEnemy()
    {
        timer += -Time.deltaTime;
        if (timer <= 0)
        {
            //Hello Whorld at 1sec
            //Debug.Log("Hello World");
            timer = Random.Range(intervalMin / level, intervalMax);

            posicao.y = Random.Range(posMin, posMax);

            //creating the enemies
            Instantiate(enemy, posicao, Quaternion.identity);
        }
    }

    public int LevelReturn()
    {
        return level;
    }

}
