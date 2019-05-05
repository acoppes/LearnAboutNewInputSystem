using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;
using UnityEngine.Experimental.Input.Plugins.Users;

public class MyPlayerInput : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _playerInput;
    
    public void OnDeviceLost(PlayerInput playerInput)
    {
        Debug.LogFormat("On device lost user: {0}", playerInput.user.id);
    }
    
    public void OnDeviceRegained(PlayerInput playerInput)
    {
        Debug.LogFormat("On device regained user: {0}", playerInput.user.id);
    }

    public void OnFireAction(InputAction.CallbackContext context)
    {
        Debug.LogFormat("On fire, user: {0}", _playerInput.user.id);
    }
}
