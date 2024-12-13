using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RspawnPoint : MonoBehaviour
{
    private bool isActive = false;
    private Material mat;
    private Color active = new Color(0, 255, 0, 0.5f);
    private Color unactive = new Color(255, 0, 0, 0.5f);
    // Start is called before the first frame update
    void Start()
    {
        mat = this.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchActive(){
        if (isActive){
            mat.color = unactive;
            isActive = false;
        } else{
            mat.color = active;
            isActive = true;
        }
    } 

    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Player") && !isActive){
            col.GetComponent<PlayerManager>().setRP(this.gameObject);
        }
    }

}
