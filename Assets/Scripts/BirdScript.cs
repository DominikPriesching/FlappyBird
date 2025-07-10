using UnityEngine;

public class BirdScript : MonoBehaviour {
    public Rigidbody2D birdsRigid;
    public float flapStrength;

    public LogicScript logic;
    private bool isAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive) {
            birdsRigid.linearVelocity = Vector2.up * flapStrength;     // Vector2.up entspricht Vector2(0,1)
        }
    }

    // Berührt der Vogel eine Pipe, erscheint der Gameover-Screen.
    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        isAlive = false;
    }
}
