using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase1 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float jump;

    float vafloat = 1.1f;
    double vardouble = 1.1234;
    int varint = 2;
    bool varbool = false;

    int[] array = new int[5] {1,2,3,4,5}; 

    List<int> lista = new List<int>();

    Vector3 posicion = new Vector3(0, 4, 2);
    Vector3 direccion = new Vector3(0, 0.67f, 0.33f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);
        Debug.Log(array[0]);
        Debug.Log(lista[0]);
        
        GameObject[] enemigos;
        enemigos = GameObject.FindGameObjectsWithTag("enemigo");

        List<GameObject> listaEnemigos = new List<GameObject>();
        foreach(GameObject enemigo in GameObject.FindGameObjectsWithTag("enemigo")){
            listaEnemigos.Add(enemigo);
        }

        Debug.Log(vafloat);
        Debug.Log(vardouble);
        Debug.Log(varint);
        Debug.Log(varbool);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            //transform.position = new Vector3(transform.position.x+speed*Time.deltaTime,transform.position.y,transform.position.z);
            rb.AddForce(new Vector3(1, 0,0)*speed*Time.deltaTime);

        } else if (Input.GetKey(KeyCode.A)){
            //transform.position = new Vector3(transform.position.x+speed*-Time.deltaTime,transform.position.y,transform.position.z);
            rb.AddForce(new Vector3(1, 0,0)*-speed*Time.deltaTime);

        } else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)){
            rb.velocity = new Vector3(rb.velocity.x*0.1f, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(new Vector3(0,1,0) * jump);
        }


        
    }
}
