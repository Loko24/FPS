using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public InputHandler inputHandler { get; private set; }
    public CharacterController characterController { get; private set; }

    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;

    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        characterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        InitializeStateMachine();
    }

    private void InitializeStateMachine()
    {
        ChangeState(new PlayerIdleState(this));
    }
}
