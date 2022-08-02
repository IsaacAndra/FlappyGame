using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    private Renderer myBack;

    private float xOffset = 0f;

    private Vector2 texturaOffset;
    [SerializeField] private float velocity = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        myBack = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        xOffset += velocity * Time.deltaTime;

        texturaOffset.x = xOffset;

        //Moving the x Offset of my Render
        myBack.material.mainTextureOffset = texturaOffset;
    }
}
