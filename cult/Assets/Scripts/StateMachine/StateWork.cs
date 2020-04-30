using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateWork : State
{
    public StateWork(Cultist connectedCultist) : base(connectedCultist)
    {

    }


    public override Type UpdateState()
    {
        if (!cultist.TESTgetYourAssToWork)
            return typeof(StateIdle);



        return typeof(StateWork);






    }



}
