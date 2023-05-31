using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public Ball ball;

    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;

    private int _playerScore;
    private int _computerScore;
    public void PlayerScores() {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
    public void ComputerScores() {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

}
