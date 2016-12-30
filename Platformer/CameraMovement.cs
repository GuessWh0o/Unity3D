using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    float smoothing = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 desPoint = new Vector3(target.position.x, target.position.y + 1.0f, -3.2f);
        transform.position = Vector3.Lerp(transform.position, desPoint, Time.deltaTime * smoothing);
        
    }
}
