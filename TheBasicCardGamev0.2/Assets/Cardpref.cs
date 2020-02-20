using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum CARDSATE {
    Field,
    Hand,
    Deck,
    Gravyard
}

public class Cardpref : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro attack;
    public TextMeshPro health;
    public TextMeshPro Cost;
    private SpriteRenderer render;
    public Card card;
    public CARDSATE state;
    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponent<SpriteRenderer>();
        title.text = card.Titel;
        Cost.text = card.Cost.ToString();
        if (card.Cardtype == CARDTYPE.Creature){            
            attack.text = ((CardCreature)card).Damage.ToString();
            health.text = ((CardCreature)card).Health.ToString();
        } else {
            attack.text = "";
            health.text = "";
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        
    }

    void OnMouseOver()
    {
        print("hall");
        render.color = Color.gray;
    }

    void OnMouseExit()
    {
        
        print("hall");
        render.color = Color.white;
    }
}