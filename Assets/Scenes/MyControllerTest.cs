using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Controls;
using UnityEngine.Experimental.Input.Layouts;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;
using UnityEngine.Experimental.Input.Plugins.Users;

public class MyControllerTest : MonoBehaviour
{
    // TODO: accion continua
    // TODO: obtener valor float de accion
    // TODO: dos o mas controllers, como se identifican?

    [SerializeField]
    private InputActionAsset _inputActions;

    private InputUser[] _users;

    private void Start()
    {
//        foreach (var device in playerInput.devices)
//        {
//            Debug.LogFormat("device: {0},{1}", device.id, device.name);
//            foreach (var control in device.allControls)
//            {
//                Debug.LogFormat("control: {0}, {1}, {2}", control.name, control.valueType, control.layout);
//            }
//        }

       //  _gamepad = InputSystem.GetDevice<Gamepad>();
        
//        playerInput.deviceLostEvent.AddListener(OnDeviceLost);
//        playerInput.deviceRegainedEvent.AddListener(OnDeviceRegained);
//        _inputDevice = playerInput.devices[0];

        InputUser.listenForUnpairedDeviceActivity = 4;
        InputUser.onUnpairedDeviceUsed += OnInputUserOnOnUnpairedDeviceUsed;
        InputUser.onChange += InputUserOnOnChange;

        _users = new InputUser[2];

        var keyboard = InputDevice.all.FirstOrDefault(d => d is Keyboard);

        if (keyboard != null)
        {
            Debug.Log("found keyboard!!");
        }
        
        for (var i = 0; i < _users.Length; i++)
        {
            _users[i] = InputUser.CreateUserWithoutPairedDevices();
            if (keyboard != null)
            {
                InputUser.PerformPairingWithDevice(keyboard, _users[i], InputUserPairingOptions.None);
            }   
        }


    }

    private void InputUserOnOnChange(InputUser user, InputUserChange change, InputDevice device)
    {
        Debug.LogFormat("Input changed: event:{0}, device:{1}", change, device != null ? device.name : "null");

        if (change == InputUserChange.DevicePaired)
        {
            Debug.LogFormat("Device paired, user: {0}", user.id);
            // TODO: destroy old scriptable object?
            
            var actions = ScriptableObject.Instantiate(_inputActions);
            user.AssociateActionsWithUser(actions);

            var player = _users.ToList().IndexOf(user);

            var actionName = string.Format("Player{0}/Movement", player);
            
            Debug.LogFormat("Find action name: {0}", actionName);
            var action = actions.FindAction(actionName);
            action.Enable();
            
            action.performed += delegate(InputAction.CallbackContext context)
            {
                var stickControl = context.control as StickControl;
                if (stickControl != null)
                    Debug.LogFormat("User: {0}.movement!, {1}", user.id, stickControl.ReadValue());
            };
            
        } else if (change == InputUserChange.DeviceUnpaired)
        {
            Debug.LogFormat("Device unpaired for user: {0}", user.id);
        }
    }

    private void OnInputUserOnOnUnpairedDeviceUsed(InputControl control)
    {
        if (control.device is Gamepad gamepad)
        {
            Debug.LogFormat("new unpaired device activity: {0}", gamepad.name);
            
            for (var i = 0; i < _users.Length; i++)
            {
                var user = _users[i];
                var pairedGamepads = user.pairedDevices.Count(d => d is Gamepad);
                if (pairedGamepads == 0)
                {
                    _users[i] = InputUser.PerformPairingWithDevice(gamepad, _users[i],
                        InputUserPairingOptions.None);
                    return;
                }
            }
        }
    }

    private void Update()
    {
        
    }

}
