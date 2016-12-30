using UnityEngine;
using System.Collections;

public class ObjectsRespawns : MonoBehaviour
{
    public GameObject poison;
    int spawnNum = 10;

    void Spawn()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            Vector3 poisonPos = new Vector3(this.transform.position.x + Random.Range(10.0f, 400.0f),
                                             this.transform.position.y + Random.Range(0.5f, 0.6f),
                                                this.transform.position.z + Random.Range(10.0f, 400.0f));
            Instantiate(poison, poisonPos, Quaternion.identity);
        }
    }
    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
