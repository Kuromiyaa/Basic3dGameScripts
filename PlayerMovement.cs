using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public float jumpSpeed = 10f;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    
    
    
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // Forward Force
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        // player movement
        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {

            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }


        if (canJump)
        {
            canJump = false;
            rb.AddForce(0, forceConst, 0, ForceMode.Impulse);


        }
    }




    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;
        }
    }


    public int forceConst = 50;

    public bool canJump;

} 
