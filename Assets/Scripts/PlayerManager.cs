using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    internal GameObject rp;
    internal GameObject rsui;
    // Start is called before the first frame update
    void Start()
    {
        rp = GameObject.Find("Spawn");
        rsui = GameObject.Find("RespawnUI");
        rsui.SetActive(false);
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void setRP(GameObject newrp){
        if(rp != null && rp.GetComponent<RspawnPoint>() != null){
            rp.GetComponent<RspawnPoint>().switchActive();
        }
        rp = newrp;
        rp.GetComponent<RspawnPoint>().switchActive();
    }

    internal void Respawn(){
        transform.position = rp.transform.position;
    }

}
