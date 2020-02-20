using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardEquipment : Card
{
    public override CARDTYPE Cardtype {        
        get { return CARDTYPE.Equipment; }
        set { }
    }
}
