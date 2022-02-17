using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public BallController ball;
    public PlayerOneController playerOne;
    public PlayerTwoController playerTwo;
    private int playerOneScore;
    private int playerTwoScore;
    public Text scoreText;

    void Update()
    {
        if (Input.GetKey("q")) {
            resetGame();
        }
    }

    public void playerOneScores()
    {
        playerOneScore++;
        resetField();
        this.scoreText.text = playerOneScore + " : " + playerTwoScore;
    }

    public void playerTwoScores()
    {
        playerTwoScore++;
        resetField();
        this.scoreText.text = playerOneScore + " : " + playerTwoScore;
    }

    private void resetField()
    {
        this.ball.reset();
        this.playerOne.reset();
        this.playerTwo.reset();
    }

    private void resetGame()
    {
        resetField();
        this.scoreText.text = "0 : 0";
    }
}
