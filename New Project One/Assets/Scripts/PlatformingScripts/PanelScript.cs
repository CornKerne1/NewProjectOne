using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject _doorScript;
    
    private bool on = false;

    // Start is called before the first frame update
    void Awake()
    {
   
    }
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(on == false)
        {
            on = true;
            _doorScript.GetComponent<DoorScript> ().unlocked = true;
        
        }
    }
   
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
