using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGoingUp : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isGoingUp", true);
        }
        else
        {
            anim.SetBool("isGoingUp", false);
        }
    }
}
