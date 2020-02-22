using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardCreature : Card
{

    public override CARDTYPE Cardtype
    {
        get { return CARDTYPE.Creature; }
        set { }
    }

    public abstract int Health { get; set;}
    public abstract int Damage { get; set;} 

    public override void Played() {
        Summon ();
    }
    public virtual void Summon () {

    }
    
}
