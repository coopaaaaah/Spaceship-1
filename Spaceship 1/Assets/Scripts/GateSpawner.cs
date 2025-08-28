using Unity.Collections;
using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public Gate gate;
    private float _maxGateSpeed = 5;
    public float spawnRate = 2;
    private float timer; // defaults to zero
    
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
        Gate newGate = Instantiate(gate, new Vector3(transform.position.x, transform.position.y - Random.Range(0, 6), 0), transform.rotation);
        newGate.SetNewSpeed(_maxGateSpeed);
    }

    void SetMaxGateSpeed(float maxSpeed)
    {
        _maxGateSpeed = maxSpeed;
    }
    
    public void IncreaseSpeed(float i)
    {
        SetMaxGateSpeed(_maxGateSpeed + i);
    }
}
