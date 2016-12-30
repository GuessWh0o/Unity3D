using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    Animator characterAnim;

    float speed = 2.0f;
    private Rigidbody2D rb2D;
    private Transform groundCheck;
    public LayerMask GroundLayers;

    private bool isGrounded;
    private bool isFighting;
    // Use this for initialization
    void Start()
    {
        groundCheck = transform.FindChild("GroundCheck");
        characterAnim = GetComponent<Animator>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        {
            float moving = Input.GetAxis("Horizontal");
            characterAnim.SetFloat("Speed", moving);
        }

        //Fighting 

        isFighting = false;
        if (isFighting == false)
        {
            if (Input.GetKey("space"))
            {
                isFighting = true;
            }
        }
        characterAnim.SetBool("isFighting", isFighting);
    }

    void FixedUpdate()
    {
        //Jumping 

        isGrounded = Physics2D.OverlapPoint(groundCheck.position, GroundLayers);

        if (isGrounded)
        {
            if (Input.GetKey("up"))
            {
                isGrounded = false;
                rb2D.AddForce(Vector2.up * 5.0f, ForceMode2D.Impulse);
            }
        }
        characterAnim.SetBool("isGrounded", isGrounded);

    }
    void Move()
    {
        if (Input.GetKey("right"))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        //    rb2D.AddForce(transform.up * 20);
    }
}
