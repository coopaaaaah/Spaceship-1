using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public Gate gate;
    public float spawnRate = 2;
    public float timer = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnGate();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnGate();
            timer = 0;
        }
    }

    void SpawnGate()
    {
        Instantiate(gate, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
