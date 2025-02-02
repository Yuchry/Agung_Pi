using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ [Header("Refrences")]
public Rigidbody rb;
public Transform head;
public Camera camera;

[Header("configurations")]
public float walkspeed;
public float runspeed;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal rotation
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 2f);
    }

    void FixedUpdate () 
    {
    Vector3 newVelocity = Vector3.up * rb.velocity.y;
    float speed = Input.GetKey (KeyCode.LeftShift) ? runspeed : walkspeed;
    newVelocity.x = Input.GetAxis("Horizontal") * speed;
    newVelocity.z = Input.GetAxis("Vertical") * speed;
    rb.velocity = transform.TransformDirection(newVelocity);
    }
    
    void LateUpdate ()
    {
        //Vertical rotation
        Vector3 e = head.eulerAngles;
        e.x -= Input.GetAxis("Mouse Y") * 2f;
        e.x = RestrictAngle (e.x, -85f, 85f);
        head.eulerAngles = e;

    }


    public static float RestrictAngle(float angle, float angleMin, float angleMax)
    {
        if (angle > 180)
        angle -= 360;
        else if (angle < -180)
        angle += 360;

        if(angle > angleMax)
        angle = angleMax;
        if(angle < angleMin)
        angle = angleMin;

        return angle;

    }
}
