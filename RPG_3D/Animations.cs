using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour
{
    private Animator playerAnim;
    // Use this for initialization
    void Start ()
    {
        playerAnim = GetComponent<Animator>();
       // playerAnim.SetBool("Fire", false);
	}

    // Update is called once per frame
    void Update()
    {
        //WALKING
        playerAnim.SetFloat("SpeedX", Input.GetAxis("Vertical"));
     
        
        if (Input.GetKeyDown("left shift"))
        {
            playerAnim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp("left shift"))
        {
            playerAnim.SetBool("Walk", false);
        }
        //FIREBALL
        if (Input.GetKeyDown(KeyCode.F))
        {
            playerAnim.SetBool("Fire", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            playerAnim.SetBool("Fire", false);
        }
        //RECHARGING
        if(Input.GetKey(KeyCode.R))
        {
            playerAnim.SetBool("Charging", true);
        }
        if(Input.GetKeyUp(KeyCode.R))
        {
            playerAnim.SetBool("Charging", false);
        }

        //JUMPING
        if (Input.GetKey("space"))
        {
            playerAnim.SetBool("Jump", true);
        }
        if (Input.GetKeyUp("space"))
        {
            playerAnim.SetBool("Jump", false);
        }

         if (Input.GetMouseButton(0))
        {
            playerAnim.SetBool("Fight", true);
        }
         if(Input.GetMouseButtonUp(0))
        {
            playerAnim.SetBool("Fight", false);
        }
    }
}
