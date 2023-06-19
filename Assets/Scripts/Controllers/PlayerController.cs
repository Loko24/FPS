using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerControl;

public class PlayerController : MonoBehaviour, IPlayerActions
{
    private PlayerControl _playerControl;
    private Player _player;
    [SerializeField]
    private float _speed;
    private Vector2 _position;


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
        _player.Speed = _speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot()
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _position = context.ReadValue<Vector2>();
    }
}
