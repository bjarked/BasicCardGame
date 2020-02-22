using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static CursorScripts;

public class CardFieldPref : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro attack;
    public TextMeshPro health;
    public CardCreature card; 
    public bool CanAttack  =false;
    public SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        title.text = card.Titel;
        attack.text = card.Damage.ToString();
        health.text = card.Health.ToString();
    }

    public void Untap () {
        CanAttack = true;
        render.color = new Color(1,0.8f,0);
    }
    public void Tap () {
        CanAttack = false;
        render.color = new Color(1,1,1);
    }

    public void Pressed () {
        print("Pressed");
        if (CanAttack){            
            render.color = new Color(1,0.2f,0.2f);
            FindObjectOfType<CursorScripts>().SetCursor(CURSOR.Attack);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
