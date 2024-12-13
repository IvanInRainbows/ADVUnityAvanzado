using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    private GameObject player;
    private Movimiento mov;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mov = player.GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void OnTriggerExit(Collider collision){
        if (collision.isTrigger == false){
            mov.isGrounded = false;
        }
    }

    public void OnTriggerStay(Collider collision){
        if (!collision.isTrigger){
            mov.isGrounded = true;
        }
    }

    public void OnTriggerEnter (Collider collision){
        if (!collision.isTrigger){
            mov.doubleJump = mov.maxDJump;
        }
    }
}
