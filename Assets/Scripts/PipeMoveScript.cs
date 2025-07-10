using System;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -40;

    //public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;    // Time.deltaTime wird ben�tigt, damit die Geschwindigkeit unabh�ngig von der Framrate gleich immer gleich bleibt.
        
        // Erreicht die Pipe eine y-Position links au�erhalb des Bildschirms, soll sie gel�scht werden.
        if(transform.position.x < deadZone) {
            Destroy(gameObject);
        }

        //if(logic.score >= 5) {
        //    moveSpeed = 10;
        //}
    }
}