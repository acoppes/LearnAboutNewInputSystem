using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Layouts;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;
using UnityEngine.Experimental.Input.Plugins.Users;

public class MyControllerTest : MonoBehaviour
{
    // TODO: accion continua
    // TODO: obtener valor float de accion
    // TODO: dos o mas controllers, como se identifican?

    [SerializeField]
    private Gamepad _gamepad;

    [SerializeField]
    private InputDevice _inputDevice;

    [SerializeField]
    private InputActionAsset _inputActions;

    private InputAction _action;

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

        _gamepad = InputSystem.GetDevice<Gamepad>();
        
//        playerInput.deviceLostEvent.AddListener(OnDeviceLost);
//        playerInput.deviceRegainedEvent.AddListener(OnDeviceRegained);
//        _inputDevice = playerInput.devices[0];

        _users = new InputUser[4];

        var keyboard = InputDevice.all.FirstOrDefault(d => d is Keyboard);
        
        for (var i = 0; i < _users.Length; i++)
        {
            _users[i] = InputUser.CreateUserWithoutPairedDevices();
            if (keyboard != null)
            {
                InputUser.PerformPairingWithDevice(keyboard, _users[i], InputUserPairingOptions.None);
            }   
        }

        InputUser.listenForUnpairedDeviceActivity = 4;
        InputUser.onUnpairedDeviceUsed += OnInputUserOnOnUnpairedDeviceUsed;
        InputUser.onChange += InputUserOnOnChange;
    }

    private void InputUserOnOnChange(InputUser user, InputUserChange change, InputDevice device)
    {
        Debug.LogFormat("Input changed: {0}, {1}, {2}", user, change, device);
        if (change == InputUserChange.DevicePaired)
        {
            // TODO: destroy old scriptable object?
            
            var actions = ScriptableObject.Instantiate(_inputActions);
            user.AssociateActionsWithUser(actions);
            
            _action = actions.FindAction("Fire");
            _action.Enable();
            
            _action.performed += delegate(InputAction.CallbackContext context)
            {
                Debug.LogFormat("User: {0}.Fire action!", user.id);
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
