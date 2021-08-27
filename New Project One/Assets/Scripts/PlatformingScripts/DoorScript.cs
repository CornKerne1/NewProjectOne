using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public bool unlocked = false;
    
    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        if (other.tag == "Player")
        {
            _animator.SetBool("openDoor", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        if (other.tag == "Player")
        {
            if (unlocked == true)
            {
                _animator.SetBool("openDoor", true);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
