using System;
using UnityEngine;

public class Gate : MonoBehaviour
{

    private float _speed = 5;
    private float _deadZone = -15;
    
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * _speed) * Time.deltaTime;
        if (transform.position.x < _deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void SetNewSpeed(float i)
    {
        _speed = i;
    }
    
}
