using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();  // Sucht in der Hierarchie nach einem GameObject mit dem Tag "Logic", dem LogicManager.
                                                                                        // In diesem wird nach einer Komponente mit dem Namen "LogicScript" gesucht, welche dann in den Slot eingesetzt wird.
                                                                                        // Jetzt kann das PipeMiddleScript das LogicScript finden, und mit ihm "sprechen", wodurch der Score verändert werden kann.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Sobald der Vogel den Raum zwischen den Röhren berührt, wird diese Methode ausgelöst.
    private void OnTriggerEnter2D(Collider2D collision) {
        // Stellt sicher, dass es wirklich der Vogel und kein anderes Objekt war, das die Kollision ausgelöst hat
        if(collision.gameObject.layer == 3) {
            logic.addScore();   // Löst die Methode addScore() im LogicScript aus
        }
    }
}