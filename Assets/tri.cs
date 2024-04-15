using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tri : MonoBehaviour
{
    public int vell;
    public int xnega, xposi;
    private Rigidbody2D _rig;
    // Start is called before the first frame update
    void Start()
    {
        _rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= xnega)
        {
            vell = 5;
            
        }
        if (this.transform.position.x >= xposi)
        {
            vell = -5;
           

        }


    }
    private void FixedUpdate()
    {
        _rig.velocity = new Vector2(1 * vell, transform.position.y);
    }
}
