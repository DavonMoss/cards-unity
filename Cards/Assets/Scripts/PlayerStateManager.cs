using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerAbstractState currentState;
    public PlayerStateFactory states;

    // Start is called before the first frame update
    void Start()
    {
        states = new PlayerStateFactory(this);
        currentState = states.Idle();
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    void SwitchState(PlayerAbstractState newState)
    {
        currentState = newState;
        currentState.EnterState(this);
    }
}
