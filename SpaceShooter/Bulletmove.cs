using UnityEngine;
using System.Collections;

public class Bulletmove : MonoBehaviour
{

    private float fireSpeed = 0.1f;
    public float bulletStrength = 20.0f;
    public GameObject newScore;

    // Use this for initialization
    void Start()
    {
        Vector3 BullPos = transform.position;
        BullPos.z = 5.0f;

        newScore = GameObject.FindWithTag("GameController");
        StartCoroutine(DestroyBullet(6.0f));
    }
    IEnumerator DestroyBullet(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.up * fireSpeed);
    }
    void OnCollisionEnter2D(Collision2D enem)
    {
        if (enem.gameObject.tag == "Enemy")
        {
            Destroy(enem.gameObject);
            newScore.GetComponent<GameController>().AddScore();
            Destroy(gameObject);
        }
    }
}