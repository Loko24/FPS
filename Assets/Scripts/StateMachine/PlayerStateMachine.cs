using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    private void Start()
    {
        InitializeStateMachine();
    }

    private void InitializeStateMachine()
    {
        ChangeState(new PlayerIdleState(this));
    }
}
