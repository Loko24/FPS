using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {

    }

    public override void Enter()
    {
        Debug.Log($"Is in Idle State");
    }

    public override void Exit()
    {
        
    }

    public override void UpdateLogic(float deltaTime)
    {
        Debug.Log($"Updating logic");
    }
}
