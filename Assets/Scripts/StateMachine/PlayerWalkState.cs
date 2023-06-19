using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{    
    public PlayerWalkState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {
    }

    public override void Enter()
    {
    }

    public override void Exit()
    {
    }

    public override void UpdateLogic(float deltaTime)
    {
        MovePlayer(deltaTime);
        ApplyRotation();

        if (playerStateMachine.inputHandler._position == Vector2.zero)
        {
            playerStateMachine.ChangeState(new PlayerIdleState(playerStateMachine));
        }
    }

    private void ApplyRotation()
    {
        Vector3 movement = new Vector3();

        movement.x = playerStateMachine.inputHandler._position.x;
        movement.z = playerStateMachine.inputHandler._position.y;
        movement.y = 0;

        if (movement != Vector3.zero)
        {
            playerStateMachine.transform.rotation = Quaternion.Slerp(playerStateMachine.transform.rotation, Quaternion.LookRotation(movement), Time.deltaTime * playerStateMachine.rotationSpeed);
        }
    }

    private void MovePlayer(float deltaTime)
    {
        Vector3 movement = new Vector3();

        movement.x = playerStateMachine.inputHandler._position.x;
        movement.z = playerStateMachine.inputHandler._position.y;
        movement.y = 0;

        playerStateMachine.characterController.Move(movement * playerStateMachine.moveSpeed * deltaTime);
    }
}
