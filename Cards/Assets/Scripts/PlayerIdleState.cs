using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerAbstractState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Just started Idling.");
    }

    public override void UpdateState(PlayerStateManager player)
    {
        Debug.Log("Vibing in Idle state.");
    }
}
