using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.CompareTag("Player")){
            //collider.gameObject.SetActive(false);
            /*Destroy(collider.gameObject);
            Destroy(this.gameObject);*/
            collider.gameObject.GetComponent<PlayerManager>().Die();
        }
    }
}
