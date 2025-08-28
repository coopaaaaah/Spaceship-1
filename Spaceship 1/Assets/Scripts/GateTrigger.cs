using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    
    public LogicManager logicManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        logicManager.IncreaseSpeed(3);
    }
}
