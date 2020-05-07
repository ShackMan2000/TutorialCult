using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class State
{


    float eatCheckTimer;


    protected Cultist cultist;

    public State(Cultist connectedCultist)
    {
        cultist = connectedCultist;
    }

    public virtual void EnterState()
    {
        eatCheckTimer = 2f;
    }


    public virtual Type UpdateState()
    {

        if (cultist.health < 0f)
            return typeof(StateDie);


        eatCheckTimer -= Time.deltaTime;
        if(eatCheckTimer < 0f)
        {
            eatCheckTimer = 2f;
            return typeof(StateEat);
        }


        return null;

    }


    public virtual void ExistState()
    {


    }











}
