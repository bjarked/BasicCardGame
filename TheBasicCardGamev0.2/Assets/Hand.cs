using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Cardpref> Cards; 
    public Cardpref cardpref;
    void Start()
    {
        
    }
    public void AddCards (List<Card> cards) {
        foreach(Card card in cards) {
            Cardpref newCard = Instantiate(cardpref);
            newCard.card = card;
            Cards.Add(newCard);
        }
    }
    public void PlaceCards () {
        int handsize = Cards.Count;
        for (int i = 0; i < handsize; i ++){
            float newX = (-(handsize-1)/2 + i) * 1.7f;
            Vector3 newPlacement = new Vector3 (newX,-3.6f,0);
            Cards[i].gameObject.transform.position = newPlacement;
        }
    }
}
