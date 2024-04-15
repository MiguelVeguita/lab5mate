using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void salir()
    {
        Debug.Log("saliendo.......");
    }
    public void jugar()
    {
        SceneManager.LoadScene("nivel 1");
    }
    public void jugar2()
    {
        SceneManager.LoadScene("nivel 2");
    }
    public void inicio()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
