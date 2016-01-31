using UnityEngine;
using System.Collections;

public class PlayerStateMachine : StateMachine<IPlayerState> {
    void Awake()
    {
        SetState<Stoj>();
    }
  
}

public interface IPlayerState : IMachineState
{

}