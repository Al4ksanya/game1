using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject pointteleport;
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = pointteleport.gameObject.transform.position;
        }
    }
}
