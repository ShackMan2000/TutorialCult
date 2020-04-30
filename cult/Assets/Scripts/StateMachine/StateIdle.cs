using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : State
{
    public StateIdle(Cultist connectedCultist) : base(connectedCultist)
    {



    }




    public override Type UpdateState()
    {
        if (cultist.TESTgetYourAssToWork)
            return typeof(StateWork);


        return typeof(StateIdle);


    }




}
