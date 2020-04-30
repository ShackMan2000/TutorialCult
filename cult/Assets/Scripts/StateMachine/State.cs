using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class State
{

    protected Cultist cultist;

    public State(Cultist connectedCultist)
    {
        cultist = connectedCultist;
    }

    public virtual void EnterState()
    {

    }


    public virtual Type UpdateState()
    {
        return typeof(State);

    }


    public virtual void ExistState()
    {


    }











}
