using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    private int enemyNum = 5;
    public GameObject gameOv;
    // Use this for initialization
    void Start()
    {
        gameOv = GameObject.FindWithTag("GameController");
        //Enemy = Instantiate(Resources.Load("Fundulet", typeof(GameObject))) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if ((Random.Range(0, 100) < enemyNum) && gameOv.GetComponent<GameController>().gameOver == false)
        {
            Vector3 randPos = new Vector3(Random.Range(-3, 3), transform.position.y, transform.position.z);
            Instantiate(Enemy, randPos, transform.rotation);   //Quaternion.Euler(90, 0, 0)
        }
    }
}
