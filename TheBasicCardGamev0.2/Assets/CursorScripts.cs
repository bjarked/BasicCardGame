using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScripts : MonoBehaviour
{
    public enum CURSOR {
        Arrow,
        Pointer,
        Attack
    }
    public Texture2D Arrow;
    public Texture2D Pointer;
    public Texture2D Attack;
    public void SetCursor (CURSOR type) {
        switch (type)
        {
            case CURSOR.Arrow : 
                Cursor.SetCursor(Arrow,Vector2.zero, CursorMode.Auto);
                break;
            case CURSOR.Pointer : 
                Cursor.SetCursor(Pointer,Vector2.zero, CursorMode.Auto);
                break;
            case CURSOR.Attack : 
                Cursor.SetCursor(Attack,Vector2.zero, CursorMode.Auto);
                break;
            
            default: break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

