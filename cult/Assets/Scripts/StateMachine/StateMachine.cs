using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{


    private State currentState;

    private Dictionary<Type, State> allStates;

    public bool printState;
 

    public void SetUpStates(Dictionary<Type, State> states, Type defaultState)
    {

        allStates = states;
        currentState = allStates[defaultState];
        currentState.EnterState();
    }




    private void Update()
    {
        if (currentState == null) return;

        if (printState)
            print(currentState);

       Type nextState =  currentState.UpdateState();

        if (nextState != currentState.GetType())
            SwitchState(allStates[nextState]);



    }



    private void SwitchState(State newState)
    {
        currentState.ExistState();

        currentState = newState;
        currentState.EnterState();

    }


}
