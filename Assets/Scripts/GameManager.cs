using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /* Things we need
     * Score - Pellets -> points (Done)
     * Next Level -> Pellets = 0
     * Lives -> Ghost touch --  -> Each Level ++
     * End of game win screen
     * End of Game lose screen
     * Score counter updated
     * Lives counter updated
     * Ghost vulnerable -> Big Pellets
     */
    private int lives = 3;
    private int score = 0;
    private Vector3 origin;
    public static GameManager GetGameManager;
    public Text ScoreText; // assigned in the inspector
    public Text LivesText;
    public GameObject PacMan;
    public GameObject GameOverPanel; 

    private void Start()
    {
        GetGameManager = this;
        //capture Pac-Man Origin as Vector3
        origin = PacMan.transform.position;
    }

    public void ScoreUpdate(int value)
    {
        score += value;
        UpdateUI();
    }

    public void LivesUpdate()
    {
        lives--;
        UpdateUI();
        //todo: Reset Pac-Man
        PacMan.transform.position = origin;
        PacMan.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //check for gameover
        if (lives <= 0)
        {
            GameOverPanel.SetActive(true);
        }
    }

    private void UpdateUI()
    {
        ScoreText.text = score.ToString();
        LivesText.text = lives.ToString();
    }

}
