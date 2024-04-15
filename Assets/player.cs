using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.Events;
using Unity.VisualScripting;

public class player : MonoBehaviour
{
    private Rigidbody2D _comporig;
    private float hori, verti;
    public float salto;
    public float raydistancia;
    public int vidaplayer;
    public bool detector;
    public LayerMask condi;
    public int color;
    public int saltorestantes;
    private SpriteRenderer _sprite;
    public int puntos;
    public Gamemanager gamemanager;
    
    
    
    public GameObject gan,bloqueador;

    public static event Action<int> damageplayer;
    public static event Action<int> puntaje;
    public static event Action lose;
    public static event Action win;


    // Start is called before the first frame update
    void Start()
    {
        _comporig = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
      
       
    }

    public void recibirdamage(int dañito)
    {
        vidaplayer = vidaplayer + dañito;
        cambiarslider();
       
    }
    void cambiarslider()
    {
        damageplayer?.Invoke(vidaplayer);
    }
    public void cambiarpuntaje(int punt)
    {
        puntos = puntos+punt;
        nuevopuntaje();

    }
    void nuevopuntaje()
    {
        puntaje?.Invoke(puntos);
    }

    // Update is called once per frame
    void Update()
    {
      
        hori = Input.GetAxisRaw("Horizontal");
        detector = Physics2D.Raycast(transform.position, new Vector2(0, -1), raydistancia, condi);
        Debug.DrawRay(transform.position, new Vector2(0, -1) * raydistancia, Color.yellow);
        if (detector == true)
        {
            saltorestantes = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space) && saltorestantes > 0)
        {
            _comporig.velocity = new Vector2(_comporig.velocity.x, salto);
            saltorestantes = saltorestantes - 1;
            if (saltorestantes == 0)
            {
                _comporig.velocity = new Vector2(_comporig.velocity.x, salto);
            }
        }
        if (vidaplayer <= 0)
        {
            lose();
        }


    }
    private void FixedUpdate()
    {
       
        _comporig.velocity = new Vector2(hori * 10, _comporig.velocity.y);

       

      
       
    }
    public void rojo()
    {
        _sprite.color = new Color(229 / 255f, 66 / 255f, 66 / 255f, 1);
        color = 2;
    }
    public void rosa()
    {
        color = 3;
        _sprite.color = new Color(214 / 255f, 70 / 255f, 206 / 255f, 1);
    }
    public void verde()
    {
        _sprite.color = new Color(87 / 255f, 224 / 255f, 77 / 255f, 1);
        color = 4;
    }
    public void azul()
    {
        _sprite.color = new Color(49 / 255f, 60 / 255f, 176 / 255f, 1);
        color = 1;
    }
    public void amarrillo()
    {
        _sprite.color = new Color(205 / 255f, 217 / 255f, 70 / 255f, 1);
        color = 5;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "rojo")
        {
            bloqueador.SetActive(true);

            if (color == 2)
            {

            }
            else
            {
                recibirdamage(-1);
                cinemachiscr.instan.movecam(1,1,0.5f);
                
            }
        }
        if (collision.tag == "rosa")
        {
            bloqueador.SetActive(true);

            if (color == 3)
            {

            }
            else
            {
                recibirdamage(-2);
                cinemachiscr.instan.movecam(2, 2, 0.5f);

            }
        }
        if (collision.tag == "verde")
        {
            bloqueador.SetActive(true);

            if (color == 4)
            {

            }
            else
            {
                recibirdamage(-2);
                cinemachiscr.instan.movecam(2, 2, 0.5f);

            }
        }
        if (collision.tag == "amarrillo")
        {
            bloqueador.SetActive(true);

            if (color == 5)
            {

            }
            else
            {
                recibirdamage(-3);
                cinemachiscr.instan.movecam(8, 8, 0.5f);

            }
        }
        if (collision.tag == "cora")

        {
            
            recibirdamage(2);

        }
        if (collision.tag == "mone")
        {
            cambiarpuntaje(1);
        }

        if (collision.tag == "salida")
        {
            gan.SetActive(true);
            Time.timeScale = 0;
        }

        if (collision.tag == "salida2")
        {
            win();
            
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "rojo")
        {
            bloqueador.SetActive(false);
        }
        if (collision.tag == "rosa")
        {
            bloqueador.SetActive(false);

        }
        if (collision.tag == "verde")
        {
            bloqueador.SetActive(false);
        }
        if (collision.tag == "amarrillo")
        {
            bloqueador.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "azul")
        {
            if (color == 1)
            {

            }
            else
            {
                recibirdamage(-3);
                cinemachiscr.instan.movecam(10, 10, 0.5f);

            }
        }
    }
}
