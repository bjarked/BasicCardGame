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
        manaPool.IncreaseMaxMana(1);
        manaPool.RefreaseMana();
        manaPool.UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
