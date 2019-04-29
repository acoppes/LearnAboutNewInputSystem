using UnityEngine;
using UnityEngine.Experimental.Input;

public class MyInputReceiver : MonoBehaviour
{
    public void OnDeviceLost()
    {
        Debug.Log("on device lost");
    }
    
    public void OnDeviceRegained()
    {
        Debug.Log("on device regained");
    }
    
    public void OnMovement()
    {
        Debug.Log("on movement");
    }
    
    public void OnTarget()
    {
        Debug.Log("on target");
    }
}
