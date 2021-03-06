using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed = 0.40f;
    public Vector3 Jump;
    public float Jumpforce = 4;
    public static bool IsPaused = false;
    public bool isGrounded;

   public Rigidbody rb;

    int step = 1; //0 = hinten 1 = mitte 2 = vorne;
    // Start is called before the first frame update
    void Start()
    {
        Jump = new Vector3(0, 4, 0);
        //InvokeRepeating("distance", 0, 1/ speed);
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        isGrounded = true;
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsPaused)
        {
            return;
        }


        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
        //{
        //    if (step < 2)
        //    {
        //        step++;
        //        transform.position += new Vector3(0, 0, 4);
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
        //{
        //    if (step > 0)
        //    {
        //        step--;
        //        transform.position -= new Vector3(0, 0, 4);
        //    }
        //}
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded || Input.GetKeyDown("up") && isGrounded)
        {
            rb.AddForce(Jump * Jumpforce, ForceMode.Impulse);
            isGrounded = false;
            //transform.position += new Vector3(0, 4, 0);
        }

        Camera.main.transform.position = new Vector3(-10, 5, 0) + transform.position;
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
        

    }

    private void FixedUpdate()
    {
        if (IsPaused)
        {
            return;
        }

        speed += 0.00005f;
        transform.position += new Vector3(speed, 0, 0);
    }

}
