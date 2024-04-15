using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.Mathematics;

public class cinemachiscr : MonoBehaviour
{
    public static cinemachiscr instan;
    private CinemachineVirtualCamera cam;
    private CinemachineBasicMultiChannelPerlin temblor;
    private float tiempomovem;
    private float total;
    private float intensidadinicio;


    // Start is called before the first frame update
    private void Awake()
    {
        instan = this;
        cam = GetComponent<CinemachineVirtualCamera>();
        temblor = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempomovem > 0)
        {
            tiempomovem -= Time.deltaTime;
            temblor.m_AmplitudeGain = math.lerp(intensidadinicio, 0, 1 - (tiempomovem / total));

        }
    }
    public void movecam(float intesidad, float frecuencia,float tiempo)
    {
        temblor.m_AmplitudeGain = intesidad;
        temblor.m_FrequencyGain = frecuencia;
        intensidadinicio = intesidad;
        total = tiempo;
        tiempomovem = tiempo;


    }
}
