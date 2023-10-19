using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode : MonoBehaviour
{
    public CharacterController characterController;

    void OnTriggerEnter2D(Collider2D other)
    {
       characterController.HasKey = true;
       Destroy(gameObject);

    }

    
}
