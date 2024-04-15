using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject player;
    private Vector3 targplayer;
    public float direci;
    public float suavisado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        targplayer = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targplayer, suavisado * Time.deltaTime);
    }
}
