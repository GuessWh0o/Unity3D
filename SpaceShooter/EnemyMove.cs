using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{
    private float enemySpeed = 3.0f;
    // Use this for initialization
    void Start()
    {
        Vector3 defaultPos = transform.position;
        defaultPos.z = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Assposition" + transform.position.z);
        transform.Translate(new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime);
    }
}
