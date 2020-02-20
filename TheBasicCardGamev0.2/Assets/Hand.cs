using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Cardpref> Cards; 
    public GameObject cardpref;
    public Player player;
    void Start()
    {
        
    }
    public void AddCards (List<Card> cards) {
        foreach(Card card in cards) {
            Cardpref newCard = Instantiate(cardpref).GetComponent<Cardpref>();
            newCard.hand = this;
            newCard.card = card;
            Cards.Add(newCard);
        }
        PlaceCards ();
    }
    public void PlaceCards () {
        int handsize = Cards.Count;
        for (int i = 0; i < handsize; i ++){
            float newX = (-(handsize-1f)/2f + i) * 2f;
            Vector3 newPlacement = new Vector3 (newX,-3.6f,0);
            Cards[i].gameObject.transform.position = newPlacement;
        }
    }
    public void PlayCard (GameObject cardObject){
        Card card = cardObject.GetComponent<Cardpref>().card;
        if (player.PayMana(card.Cost)){
            Cards.Remove(cardObject.GetComponent<Cardpref>());
            Destroy(cardObject);
        } else {
            print("To high cost");
        }
        PlaceCards ();
    }
}
