using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;

    private int _playerScore;
    private int _computerScore;
    public void PlayerScores() {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ResetObjects();
    }
    public void ComputerScores() {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ResetObjects();
    }

    private void ResetObjects() {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
