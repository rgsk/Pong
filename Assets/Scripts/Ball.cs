using UnityEngine;

public class Ball : MonoBehaviour {
    private float speed = 200.0f;

    private Rigidbody2D _rigidbody;
    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
        AddStartingForce();
    }

    private void AddStartingForce() {
        var x = Utils.Toss() ? -1.0f : 1.0f;
        var y = Utils.Toss() ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        var direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
    public void AddForce(Vector2 force) {
        _rigidbody.AddForce(force);
    }
}
