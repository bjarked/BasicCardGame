using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCard : CardCreature
{
    public override string Titel { get {return "Knight";} set{}}
    public override int Cost { get {return 4;} set{}}
    public override int Health { get {return 4;} set{}}
    public override int Damage { get {return 3;} set{}}
}
 