using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public int enemyCurrentHealth;
    public int enemyMaxHealth = 5;
    public float speed = 0.8f;

    public float distance;
    public float awakeDist;

    public bool awake = false;


    public Transform initPos;
    public Transform playerTarget;
    // Use this for initialization


    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        Vector2 posEn = initPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        Vector2 plaPos = playerTarget.transform.position;
        Vector2 myPos = this.transform.position;

        //distance = plaPos.x - myPos.x;
        distance = Vector2.Distance(plaPos, myPos);


        if (distance < 3.0f)
        {
            Attack();
        }
        if(distance > 3.0f)
        {
            
        }
    }

    void Attack()
    {
        //float distance = this.transform.position.x - playerTarget.transform.position.x;
        //float direction = Mathf.Sign(distance);

        //Vector2 newPos = new Vector2(this.transform.position.x - direction * speed * Time.deltaTime, this.transform.position.y);
        ////transform.position  += (playerTarget.transform.position - transform.position) * speed * Time.deltaTime;
        Vector2 newPos = this.transform.position;
        newPos.x = Mathf.Lerp(this.transform.position.x, playerTarget.position.x, Time.deltaTime * speed);
        transform.position = newPos;
    }
    void GoBack()
    {

    }

       
}
