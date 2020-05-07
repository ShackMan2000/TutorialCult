using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cultist : MonoBehaviour
{



    public bool TESTgetYourAssToWork;


    public float health;



    private StateMachine stateMachine;



    private void Awake()
    {

        health = 100f;

        stateMachine = GetComponent<StateMachine>();

        Dictionary<Type, State> allStates = new Dictionary<Type, State>()
        {
            {typeof(StateIdle), new StateIdle(this) },
            {typeof(StateWork), new StateWork(this) },
            {typeof(StateEat), new StateEat(this) },
            {typeof(StateDie), new StateDie(this) },
            {typeof(StateSleep), new StateSleep(this) },
        };


        stateMachine.SetUpStates(allStates, typeof(StateIdle));

       


    }



    public void ChangeHealth(float amount)
    {
        health += amount;
        print("got punched in the face and lost " + amount + " health");

    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeHealth(-40f);
    }



}
