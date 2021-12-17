using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    int step = 1; //0 = hinten 1 = mitte 2 = vorne

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);       

        if(Input.GetKeyDown(KeyCode.W))
        {
            if(step < 2)
            {
                step++;
                transform.position += new Vector3(0, 0, 4);
            }         
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (step > 0)
            {
                step--;
                transform.position -= new Vector3(0, 0, 4);
            }
        }
    }
}
