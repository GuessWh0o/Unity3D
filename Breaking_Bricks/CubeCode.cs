using UnityEngine;
using System.Collections;

public class CubeCode : MonoBehaviour
{

    void OnTriggerEnter(Collider box)
    {
        if(box.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        Debug.Log("triggers");
    }

    // Use this for initialization
    void Start()
    {
            //GameObject cloneHealth = GameObject.Find("GM").GetComponent<GM>().lives = 3;
}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * 0.1f, 0);
    }

}
