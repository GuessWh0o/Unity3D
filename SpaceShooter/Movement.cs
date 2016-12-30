using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public GameObject bullet;


    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {

            Vector3 penisPos = transform.position;

        if (Input.GetKey("right") && this.transform.position.x < 3.5f)
        {
            this.transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey("left") && this.transform.position.x > -2.7f)
        {
            this.transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            penisPos.x = penisPos.x + 0.4f;
            penisPos.y = penisPos.y + 1.3f;

            Instantiate(bullet, penisPos, Quaternion.Euler(0, 0, 180));
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
