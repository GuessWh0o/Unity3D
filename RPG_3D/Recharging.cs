using UnityEngine;
using System.Collections;

public class Recharging : MonoBehaviour
{
    // Use this for initialization
     void Start()
    {
        StartCoroutine(Destroycharge(2.0f));
    }
    IEnumerator Destroycharge(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }
}
