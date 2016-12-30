using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int currHealth;
    public int maxHealth = 3;
 //   private int maxHealth{ get; set; }
 

    public int currentMana;
    public int maxMana = 3;
    // Use this for initialization
    void Start()
    {
        currHealth = maxHealth;
        currentMana = maxMana;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Checking Health

        if (currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }
        if (currHealth <= 0)
        {
            Die();
        }
        //Checking Mana
        if(currentMana > maxMana)
        {
            currentMana = maxMana;
        }
    }

    void Update()
    {

    }
    
    void OnCollisionEnter2D(Collision2D mana)
    {
        if(mana.gameObject.tag == "Mana")
        {
            if(currentMana < 3)
            {
                currentMana += 1;
                Destroy(mana.gameObject);
            }   
        }

        if(mana.gameObject.tag == "HP")
        {
            if (currHealth < 3)
            {
                currHealth += 1;
                Destroy(mana.gameObject);
            }
        }
        if(mana.gameObject.tag == "Enemy")
        {
            currHealth--;
        }
    }

    void Die()
    {
        SceneManager.LoadScene(0);
    }
}
