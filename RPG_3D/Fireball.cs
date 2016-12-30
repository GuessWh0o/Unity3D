using UnityEngine;
using System.Collections;

public class Fireball: MonoBehaviour
{
    private float fireSpeed = 1.0f;
    public float fireballStrength = 20.0f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Destroyfireball(2.0f));
	}
     IEnumerator Destroyfireball(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }

	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.forward * fireSpeed);
    }
}
