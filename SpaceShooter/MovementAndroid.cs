using UnityEngine;
using System.Collections;


public class MovementAndroid : MonoBehaviour
{
    public GameObject bullet;

    private float shipSpeed = 6.0f;
    private int rotationSpeed = 50;

    public  GameObject textsGame;
    Rigidbody2D rb;

    void Start()
    {
        textsGame = GameObject.FindWithTag("GameController");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
        AccelerometerMove();

        Vector3 penisPos = transform.position;

        penisPos.x = Mathf.Clamp(penisPos.x, -3.5f, 3.5f);   //-0.7f, 1.0f
        transform.position = penisPos;


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                penisPos.x = penisPos.x - 0.1f;  
                penisPos.y = penisPos.y + 2.5f;

                Instantiate(bullet, penisPos, Quaternion.Euler(0, 0, 180));
            }
        }
    }

    void AccelerometerMove()
    {
        float x = Input.acceleration.x;
        if (x < -0.1f)
        {
            MoveLeft();
        }
        else if (x > 0)
        {
            MoveRight();
        }
        else
            DontMove();
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-shipSpeed, 0);
        transform.Rotate(Vector3.down, Time.deltaTime * rotationSpeed);
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(shipSpeed, 0);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
    }

    public void DontMove()
    {
        rb.velocity = Vector2.zero;
        transform.Rotate(0, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            textsGame.GetComponent<GameController>().GameOver();
            //Destroy(gameObject);
           // SceneManager.LoadScene(0);
        }
    }
}
