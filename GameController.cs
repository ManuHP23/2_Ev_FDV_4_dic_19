using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Idle, Playing, Ended }

public class GameController : MonoBehaviour
{
    public GameState gameState = GameState.Idle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == GameState.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)))
        {
            gameState = GameState.Playing;
            
        }
    }
}

