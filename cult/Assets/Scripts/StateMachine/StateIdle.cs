using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : State
{
    public StateIdle(Cultist connectedCultist) : base(connectedCultist)
    {



    }


    public override void EnterState()
    {
        base.EnterState();
    }



    public override Type UpdateState()
    {

       Type priorityState =  base.UpdateState();
        if (priorityState != null)
            return priorityState;


        if (cultist.TESTgetYourAssToWork)
            return typeof(StateWork);


        return typeof(StateIdle);


    }




}
