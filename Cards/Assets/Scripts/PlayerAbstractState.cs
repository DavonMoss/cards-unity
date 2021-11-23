using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAbstractState
{
    public abstract void EnterState(PlayerStateManager player);
    public abstract void UpdateState(PlayerStateManager player);
}
