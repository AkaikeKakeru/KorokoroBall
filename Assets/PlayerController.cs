using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 0.01f;

    public Rigidbody rigidbody;

    public int stageNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (stageNum) 
        {
            case 2:
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    
                    rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {

                    rigidbody.AddForce(new Vector3(1, 0, 0) * power);
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    
                    rigidbody.AddForce(new Vector3(0, 0, -1) * power);
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    
                    rigidbody.AddForce(new Vector3(0, 0, 1) * power);
                }
                break;

            case 1:
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rigidbody.AddForce(new Vector3(0, 0, 1) * power);
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rigidbody.AddForce(new Vector3(0, 0, -1) * power);
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rigidbody.AddForce(new Vector3(1, 0, 0) * power);
                }
                break;
        }
        

      

    }
}
