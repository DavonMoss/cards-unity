using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateFactory
{
    PlayerStateManager player;

    public PlayerStateFactory(PlayerStateManager currentPlayer)
    {
        player = currentPlayer;
    }

    // State getters.
    public PlayerAbstractState Idle()
    {
        return new PlayerIdleState();
    }
}
