using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State _currentState;

    public void ChangeState(State state)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
        }
        _currentState = state;
        _currentState.Enter();
    }

    private void Update()
    {
        if (_currentState != null)
        {
            _currentState.UpdateLogic(Time.deltaTime);
        }
    }
}
