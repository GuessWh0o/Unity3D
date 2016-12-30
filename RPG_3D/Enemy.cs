using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    private float enemyHealth = 100.0f;
    public GameObject boom;

    private float speed = 4.0f;
    private float range = 10.0f;

    public Transform player;
    public CharacterController enemycontroller;

    void Chase()
    {
        transform.LookAt(player.position);
        enemycontroller.SimpleMove(transform.forward * speed);
    }
	// Use this for initialization
	void Start ()
    {
        enemyHealth = 100.0f;
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.position) < range)
        {
            Chase();
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Fireball")
       {
           enemyHealth = (enemyHealth - RandomDamageFireball(0));
          if (enemyHealth <= 0.0f)
            {
               Destroy(this.gameObject);
                Instantiate(boom, transform.position, transform.rotation);
            }
       }
        
    }
    static float RandomDamageFireball(float ran)
    {
        ran = UnityEngine.Random.Range(15.0f, 35.0f);
        return ran;
    }
}
