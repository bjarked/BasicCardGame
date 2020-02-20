using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardFieldPref : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro attack;
    public TextMeshPro health;
    public CardCreature card; 
    // Start is called before the first frame update
    void Start()
    {
        title.text = card.Titel;
        attack.text = card.Damage.ToString();
        health.text = card.Health.ToString();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
