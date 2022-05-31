using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float power = 0.01f;

    public int timer = 100;

    public int timerDef = 100;

    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer--;
        if(timer < 0)
        {
            power *= -1;
            timer = timerDef;
        }

        //transform.Translate(new Vector3(power, 0, 0));

            rigidbody.AddForce(new Vector3(power, 0, 0));
        
    }
}
