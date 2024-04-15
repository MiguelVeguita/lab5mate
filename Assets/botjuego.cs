using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botjuego : MonoBehaviour
{
   
    private SpriteRenderer _sprite;
    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rojo()
    {
        _sprite.color = new Color(229 / 255f, 66 / 255f, 66 / 255f, 1);
    }
    public void rosa()
    {
        
        _sprite.color = new Color(214 / 255f, 70 / 255f, 206 / 255f, 1);
    }
    public void verde()
    {
        _sprite.color = new Color(87 / 255f, 224 / 255f, 77 / 255f, 1);
    }
    public void azul()
    {
        _sprite.color = new Color(49 / 255f, 60 / 255f, 176 / 255f, 1);

    }
    public void amarrillo()
    {
        _sprite.color = new Color(205 / 255f, 217 / 255f, 70 / 255f, 1);
    }
}
