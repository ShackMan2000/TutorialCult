using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateEat : State
{

    float timeForEating;


    public StateEat(Cultist connectedCultist) : base(connectedCultist)
    {
    }



    public override void EnterState()
    {
        timeForEating = 3f;

    }


    public override Type UpdateState()
    {
        Type priorityState = base.UpdateState();
        if (priorityState != null)
            return priorityState;


        timeForEating -= Time.deltaTime;

        if (timeForEating < 0f)
            return typeof(StateSleep);

        return typeof(StateEat);

    }

}
