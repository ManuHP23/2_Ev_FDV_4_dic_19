﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTree : MonoBehaviour
{
    public enum GameState { Idle, Playing, Ended }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            gameObject.GetComponent<Animator>().SetBool("attack", true);
        }
        public GameState gameState = GameState.Idle;
}
}
