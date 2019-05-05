using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

public class MyGamePlayersManager : MonoBehaviour
{
    public void OnPlayerJoined(PlayerInput playerInput)
    {
        Debug.LogFormat("Player {0} joined", playerInput.user.id);
    }

    public void OnPlayerLeft(PlayerInput playerInput)
    {
        Debug.LogFormat("Player {0} left", playerInput.user.id);
    }
}
