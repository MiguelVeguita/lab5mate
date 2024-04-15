using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scripSlider : MonoBehaviour
{
    public Slider barravida;
    // Start is called before the first frame update
    void Start()
    {
        player.damageplayer += cambiarslider;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void cambiarslider(int vidaplayer)
    {


        barravida.value = vidaplayer;
    }
}
