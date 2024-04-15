using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI tiempito;
    public TextMeshProUGUI puntos;
    public GameObject pau;
    public float ti;
    public int puntitos;
    public static event Action perderr;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        tiempito.text = "Tiempo:0";
        puntos.text = "Puntaje:0";
        ti = 0;
        player.puntaje += cambiopuntaje;
        player.lose += lose;
        player.win += win;
        
    }

    // Update is called once per frame
    void Update()
    {
        ti = ti + Time.deltaTime;
        tiempito.text = "Tiempo: " + ti.ToString("F0") + "s";


    }
    public void win()
    {
        SceneManager.LoadScene("ganar");
    }
    public void lose()
    {
        SceneManager.LoadScene("perder");
    }
   
    void cambiopuntaje(int pun)

    {
        puntitos = pun;
        puntos.text = "Puntaje:" + puntitos;
    }

    public void PAUSAR()
    {
        Time.timeScale = 0;
        pau.SetActive(true);
    }
    public void reanuadar()
    {
        Time.timeScale = 1;
        pau.SetActive(false);
    }
    public void inicio()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void lv2()
    {
        SceneManager.LoadScene("nivel 2");
    }
}
