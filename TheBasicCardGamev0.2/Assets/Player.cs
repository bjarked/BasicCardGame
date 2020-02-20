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
    void Start()
    {
        manaPool.UpdateText();
        deck.Shuffle();
        hand.AddCards(deck.Draw(5));
        hand.PlaceCards();

        DrawPhase();
    }

    void DrawPhase () {
        manaPool.IncreaseMaxMana(5);
        manaPool.RefreaseMana();
        manaPool.UpdateText();
    }

    public bool PayMana (int mana) {
        return manaPool.SpendMana(mana);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
