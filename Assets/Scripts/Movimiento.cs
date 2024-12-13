using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float jump;
    internal bool isGrounded;
    public int doubleJump = 3;
    internal int maxDJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        maxDJump = doubleJump;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            //transform.position = new Vector3(transform.position.x+speed*Time.deltaTime,      transform.position.y,        transform.position.z);
            rb.AddForce(new Vector3(1, 0,0)*speed*Time.deltaTime);

        } else if (Input.GetKey(KeyCode.A)){
            //transform.position = new Vector3(transform.position.x+speed*-Time.deltaTime,transform.position.y,transform.position.z);
            rb.AddForce(new Vector3(1, 0,0)*-speed*Time.deltaTime);
        } 
        
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)){
            rb.velocity = new Vector3(rb.velocity.x*0.1f, rb.velocity.y, rb.velocity.z);
        }

        /*if (isGrounded){
            doubleJump = maxDJump;
        }*/

        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true){
            rb.AddForce(new Vector3(0,1,0) * jump);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == false && doubleJump > 0){
            rb.AddForce(new Vector3(0,1,0) * jump);
            doubleJump--;
        }*/

        if (Input.GetKeyDown(KeyCode.Space)){
            if (isGrounded){
                rb.AddForce(new Vector3(0,1,0) * jump);
            } else if (doubleJump > 0){
                rb.AddForce(new Vector3(0,1,0) * jump);
                doubleJump--;
            }
        }


        
    }
}
