using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerControl;

public class InputHandler : MonoBehaviour, IPlayerActions
{
    private PlayerControl _playerControl;
    public Vector2 _position { get; private set; }

    private void Awake()
    {
        _playerControl = new PlayerControl();
        _playerControl.Player.SetCallbacks(this);
    }

    private void OnEnable()
    {
        _playerControl.Enable();
    }

    private void OnDisable()
    {
        _playerControl.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _position = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }
}
