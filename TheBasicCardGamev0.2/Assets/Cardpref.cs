﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static CursorScripts;

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
    public Hand hand;
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
            Destroy(attack.gameObject.transform.parent.gameObject);
            Destroy(health.gameObject.transform.parent.gameObject);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        hand.PlayCard(this.gameObject);
    }

    void OnMouseOver()
    {
        render.color = Color.gray;
        FindObjectOfType<CursorScripts>().SetCursor(CURSOR.Pointer);
    }

    void OnMouseExit()
    {
        render.color = Color.white;
        FindObjectOfType<CursorScripts>().SetCursor(CURSOR.Arrow);
    }
}