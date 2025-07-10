using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Pipe-Prefab
    public GameObject pipePrefab;

    // Timer-Variablen
    private float spawnRate = 2;    // Zeitabstand zwischen den Spawns
    private float timer = 2;        // Startet mit dem Wert 2, damit gleich zu Beginn eine Pipe gesetzt wird, und man nicht 2 Sekunden warten muss
    // Zufallsgrenzen für spawnRate
    public float minSpawnTime = 1;
    public float maxSpawnTime = float.Parse("1.5");

    
    // Größtmöglicher Spawnabstand in y zum Spawner
    public float hightOffset = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float highestSpawn = transform.position.y + hightOffset;    // Höchster Spawnpunkt
        float lowsetSpan = transform.position.y - hightOffset;      // Geringster Spawnpunkt

        if (timer < spawnRate){
            timer += Time.deltaTime;    // Ist der Timer noch nicht hoch genug, wird er um die verstrichene Zeit inkrementiert.
        } else {
            Instantiate(pipePrefab, new Vector2(transform.position.x, Random.Range(lowsetSpan, highestSpawn)), transform.rotation);  // Hat der Timer den Spawnwert erreicht, wird eine neue Pipe mit zufälliger y-Position gespawnt,
            timer = 0;      // und der Timer auf null zurückgesetzt.
            //spawnRate = Random.Range(minSpawnTime, maxSpawnTime);     // Berechnet einen zufälligen Wert für die nächste Spawnrate
        }
    }
}
