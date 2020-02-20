using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Deck deck;
    public Hand hand;
    public ManaPool manaPool;
    // Start is called before the first frame update
    void Start() //Start
    {
        StartPhase ();
    }
    void StartPhase () {        
        manaPool.UpdateText();
        deck.Shuffle();
        hand.AddCards(deck.Draw(5));
        manaPool.IncreaseMaxMana(1);
        manaPool.RefreaseMana();
        manaPool.UpdateText();
    }

    void DrawPhase () {
        manaPool.IncreaseMaxMana(1);
        manaPool.RefreaseMana();
        manaPool.UpdateText();
        hand.AddCards(deck.Draw(1));
    }

    void EndPhase () {
        DrawPhase ();
    }

    public bool PayMana (int mana) {
        return manaPool.SpendMana(mana);
    }

    public void EndTurn () {
        EndPhase ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
