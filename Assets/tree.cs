using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tree : MonoBehaviour 
{
    public Animator animator;

    void Start()
    {

    }

    void Update(){

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Enter");
            animator.SetTrigger("size down");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))

        
           

        {
            Debug.Log("Exit");
            animator.SetTrigger("size up");
        }
    }

}
