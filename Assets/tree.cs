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
            animator.SetTrigger("size down");
        }
    }

}
