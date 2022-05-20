using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
        {
            playerAnim.SetTrigger("left");
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
        {
            playerAnim.SetTrigger("right");
        }      
    }
}
