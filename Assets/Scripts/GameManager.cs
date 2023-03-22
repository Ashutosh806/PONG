using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle,computerPaddle;
    public Text playerScoreText,computerScoreText;
    private int playerScore,computerScore;

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
       computerScore++;
       this.computerScoreText.text = computerScore.ToString();
       ResetRound();
    }
    
    private void ResetRound()
    {
       this.ball.ResetPosition();
       this.ball.AddStartingForce();
       this.playerPaddle.ResetPosition();
       this.computerPaddle.ResetPosition();
    } 


}
