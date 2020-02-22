using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public List<CardFieldPref> Cards; 
    public CardFieldPref cardFieldPref;

    public void AddCards (CardCreature card) {
        List<CardCreature> cards = new List<CardCreature>();
        cards.Add(card);
        AddCards(cards);
    }
    public void AddCards (List<CardCreature> cards) {
        foreach(CardCreature card in cards) {
            CardFieldPref newCard = Instantiate(cardFieldPref).GetComponent<CardFieldPref>();
            //newCard.hand = this;
            newCard.card = card;
            Cards.Add(newCard);
        }
        PlaceCards ();
    }
    public void PlaceCards () {
        int armysize = Cards.Count;
        for (int i = 0; i < armysize; i ++){
            float newX = (-(armysize-1f)/2f + i) * 2f;
            Vector3 newPlacement = new Vector3 (newX,0,0);
            Cards[i].gameObject.transform.position = newPlacement;
        }
    }
}
