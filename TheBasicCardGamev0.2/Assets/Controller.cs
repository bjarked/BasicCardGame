using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CursorScripts;

public class Controller : MonoBehaviour
{
    public Camera Camera;
    public Player player;
    public Enemy enemy;
    public GameObject Object;
    public CursorScripts Cursor;
    public bool isDraging = false; 
    void Start() {
        Cursor = Camera.GetComponent<CursorScripts>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            RaycastHit2D hit;
            Vector2 MP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(MP, -Vector2.up);
            if (hit.collider != null) {
                Object = hit.transform.gameObject;
                CardFieldPref script = Object.GetComponent<CardFieldPref>();
                if (script != null && script.CanAttack) {
                    isDraging = true; 
                    script.Pressed();
                    enemy.MakeTargetible();
                }
                
            }
        }
        if (isDraging &&  Input.GetMouseButtonUp(0)){              
            RaycastHit2D hit;
            Vector2 MP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(MP, -Vector2.up);

            if (hit.collider != null && hit.transform.gameObject.tag == "Enemy") {       
                FindObjectOfType<CursorScripts>().SetCursor(CURSOR.Arrow);             
                CardFieldPref script = Object.GetComponent<CardFieldPref>();
                enemy.TakeDamage(script.card.Damage);                
                script.Tap();
                isDraging = false;
                enemy.MakeUnTargetible();

            } else {
                FindObjectOfType<CursorScripts>().SetCursor(CURSOR.Arrow);            
                CardFieldPref script = Object.GetComponent<CardFieldPref>();
                script.Untap();
                isDraging = false;
                enemy.MakeUnTargetible();
            }
        }
    }

}
