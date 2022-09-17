using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    public Transform ball;
    private GameManager game_Manager;
    void Start()
    {
        game_Manager = GameObject.FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y+12.5f >= ball.position.y)
        {
            Destroy(gameObject);
            game_Manager.GameScore(50);
        }
    }
}
