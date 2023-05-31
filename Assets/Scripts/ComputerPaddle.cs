using UnityEngine;
public class ComputerPaddle : Paddle {

    public Rigidbody2D ball;

    private void FixedUpdate() {
        if (this.ball.velocity.x > 0.0f) {
            // ball is moving to the right
            if (this.ball.position.y > this.transform.position.y) {
                // ball is above
                // add force to the paddle to move up
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        } else {
            if (this.transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }

    }

}
