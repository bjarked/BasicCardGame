using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaPool : MonoBehaviour
{
    public Text text;
    public int Mana = 0;
    public int MaxMana = 0;
    public void UpdateText () {
        text.text = Mana + "/" + MaxMana;
    }
    public void IncreaseMaxMana (int number) {
        MaxMana += number;
    }
    public void AddTemporaryMana(int number) {
        Mana += number;
    }

    public void RefreaseMana () {
        Mana = MaxMana;
    }
}
