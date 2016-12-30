using UnityEngine;
using System.Collections;

public class Magic: MonoBehaviour
{
    public GameObject fireball;
    public GameObject recharging;

    bool fire;
    bool rech;
    // Use this for initialization
    void Start ()
    {
        fire = false;
        rech = false;
    }
    	
	// Update is called once per frame
	void Update ()
    {
        //fireball

        if (fire == false && Input.GetKey(KeyCode.F))
        {
            FireballFunction();
            fire = true;                                    //Preventing of fireball looping
             
        }
        if (!Input.GetKey(KeyCode.F))
        {
            fire = false;
        }

        //recharging

        if (rech == false && Input.GetKey(KeyCode.R))
        {
            RechargingFunction();
            rech = true;
        }
        if (!Input.GetKey(KeyCode.R))
        {
            rech = false;      
        }

    }
    
    //Instantiating Fireball

    void FireballFunction()
    {
        fireball.transform.position = transform.position + Camera.main.transform.forward * 2 + Camera.main.transform.up * 1.5f; //Aligning fireball 
                                                                                                                                    //in face of Player
        Instantiate(fireball, fireball.transform.position, transform.rotation);
    }

    //Recharging Players Health 

    public void RechargingFunction()
    {
        Vector3 pPos = transform.position; 
        Instantiate(recharging, pPos, transform.rotation);
        GameObject.Find("Player").GetComponent<PlayerSystem>().playerHealth = 100;
        GameObject.Find("Player").GetComponent<PlayerSystem>().healthBar.value = 0.0f;
    }
}
