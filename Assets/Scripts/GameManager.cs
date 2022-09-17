using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private int score;

    public TMPro.TMP_Text score_Text;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void GameScore(int ring_Score)
    {
        score += ring_Score;
        score_Text.text = score.ToString();

    }
}
