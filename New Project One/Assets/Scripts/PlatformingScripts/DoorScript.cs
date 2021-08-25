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
        _animator = GetComponent<Animator>();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("openDoor", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (unlocked == true && other.tag == "Player")
        {
            _animator.SetBool("openDoor", true);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
