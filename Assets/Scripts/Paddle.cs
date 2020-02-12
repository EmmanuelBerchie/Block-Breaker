using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration Parameters 

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float screenMin = 1.05f;
    [SerializeField] float screenMax = 14.99f;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector 2 is a compact way of storing x and y componenents, do not need y because it is a 2d game
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXpos(), screenMin, screenMax);
        transform.position = paddlePos;
    }
    
    private float GetXpos()
    {
        if(FindObjectOfType<GameStatus>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x; 
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;

        }
    }

    }

