using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
	public float speed = 0.1f;


	void Start()
	{
		transform.position = new Vector3(0 ,-8.7f, 0);
	}

    void Update()
    {
        Vector3 paddlePos = transform.position;
        paddlePos.x = Mathf.Clamp(paddlePos.x, -7.7f, 7.7f);
        transform.position = paddlePos;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;

			transform.Translate (touchDeltaPosition.x * speed, 0, 0);

		} 

	}

}
	