using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /* Things we need
     * Score - Pellets -> points
     * Next Level -> Pellets = 0
     * Lives -> Ghost touch --  -> Each Level ++
     * End of game win screen
     * End of Game lose screen
     * Score counter updated
     * Lives counter updated
     * Ghost vulnerable -> Big Pellets
     */
    private int score = 0;
    public static GameManager GetGameManager;
    public Text ScoreText; // assigned in the inspector

    private void Start()
    {
        GetGameManager = this;
    }

    public void ScoreUpdate(int value)
    {
        score += value;
        UpdateUI();
    }

    private void UpdateUI()
    {
        ScoreText.text = score.ToString();
    }

}
