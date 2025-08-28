using UnityEngine;

public class LogicManager : MonoBehaviour
{
    
    public GateSpawner gateSpawner;

    public void IncreaseSpeed(float i)
    {
        gateSpawner.IncreaseSpeed(i);
    }
}
