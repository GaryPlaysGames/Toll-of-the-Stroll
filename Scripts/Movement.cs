using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public GameObject my_object;
    private Rigidbody rb;
    float horizontalSpeed = 2;
    float verticalSpeed = 2;

    private float rotationY = 0f;
    private float sensitivityY = 2f;
    private float rotationX = 0f;


    void Start() 
    {
        rb = my_object.GetComponent<Rigidbody>();
    }
    
    
    void Update () 
    {


	    if (Input.GetButtonDown("Vertical"))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, 100));        
        }

        if (Input.GetButtonDown("Horizontal"))
        {
            rb.AddForce(new Vector3(100, 0.0f, 0));
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, 100, 0));
        }
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        rotationX += h;
        rotationY += v;
        rotationY = Mathf.Clamp(rotationY, -45, 45);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX , transform.localEulerAngles.z);
    }
	
}
