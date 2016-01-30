using UnityEngine;
using System.Collections;

public class PlayerStateMachine : StateMachine<IPlayerState> {
    void Awake()
    {
        SetState<Patrol>();
    }
	
}

public interface IPlayerState : IMachineState
{

}