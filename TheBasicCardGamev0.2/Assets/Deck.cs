using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> Cards; 
    public void Shuffle () {
        int count = Cards.Count;  
        while (count > 1) {  
            count--;  
            int k = Random.Range(0,count + 1);
            Card value = Cards[k];  
            Cards[k] = Cards[count];  
            Cards[count] = value;  
        }  
    }
    public List<Card> Draw () {
        return Draw(1);
    }
    public List<Card> Draw (int number) {
        List<Card> returnList = Cards.GetRange(0, number);
        Cards.RemoveRange(0, number);
        return returnList;
    }
}
