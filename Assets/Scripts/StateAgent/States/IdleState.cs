using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{

    public IdleState(StateAgent owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        owner.timer.value = Random.Range(1, 3);
        
    }

    public override void OnExit()
    {
        Debug.Log("Idle Exit");
    }

    public override void OnUpdate()
    {
       //
    }
}
