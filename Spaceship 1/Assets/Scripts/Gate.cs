using UnityEngine;

public class Gate : MonoBehaviour
{

    private int _speed = 5;
    private float _deadZone = -45;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * _speed) * Time.deltaTime;
        if (transform.position.x < _deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void SetNewSpeed(int i)
    {
        _speed = i;
    }
}
