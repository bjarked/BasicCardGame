using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public TextMeshPro HealthText;
    public SpriteRenderer render;
    public int Health = 20;

    void Start () {
        render = GetComponent<SpriteRenderer>();
        UpdateText ();
    }
    void UpdateText () {
        HealthText.text = Health.ToString();
    }
    public void MakeTargetible () {
        render.color = new Color(1,0.8f,0);
    }
    public void MakeUnTargetible () {
        render.color = new Color(1,1,1);
    }

    public void TakeDamage (int number) {
        Health -=number;
        UpdateText ();
    }

}
