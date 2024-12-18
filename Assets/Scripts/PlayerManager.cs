using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Respawn(){
        rsui.SetActive(false);
        this.gameObject.SetActive(true);
        this.GetComponent<Rigidbody>().velocity *=  0;
        transform.position = rp.transform.position;
    }

    public void Die(){
        this.gameObject.SetActive(false);
        rsui.SetActive(true);
    }

    public void reload(){
        SceneManager.LoadScene("SampleScene");
    }
}
