using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cultist : MonoBehaviour
{



    public bool TESTgetYourAssToWork;






    private StateMachine stateMachine;



    private void Awake()
    {
        stateMachine = GetComponent<StateMachine>();

        Dictionary<Type, State> allStates = new Dictionary<Type, State>()
        {
            {typeof(StateIdle), new StateIdle(this) },
            {typeof(StateWork), new StateWork(this) },
            {typeof(StateEat), new StateEat(this) },
        };


        stateMachine.SetUpStates(allStates, typeof(StateIdle));

       


    }






}
