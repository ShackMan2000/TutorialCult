using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateSleep : State
{
    public StateSleep(Cultist connectedCultist) : base(connectedCultist)
    {
    }






    public override Type UpdateState()
    {
        cultist.health -= 50f * Time.deltaTime;

        Type priorityState = base.UpdateState();
        if (priorityState == typeof(StateDie))
            return priorityState;


        return typeof(StateSleep);
    }

}
