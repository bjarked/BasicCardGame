using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CARDTYPE {
    Creature, 
    Spell,
    Equipment
}
public abstract class Card : MonoBehaviour
{
    public abstract string Titel { get; set;} 
    public abstract int Cost { get; set;}
    public abstract CARDTYPE Cardtype { get; set;}

    public virtual void Played (){}
}
