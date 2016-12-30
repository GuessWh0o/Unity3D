using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
    public int playerHealth;
    private bool check;
    public Slider healthBar;
    // Use this for initialization
    void Start ()
    {
        playerHealth = 100;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(playerHealth);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            playerHealth -= 20;
            healthBar.value = -playerHealth;
        }
    }
}
