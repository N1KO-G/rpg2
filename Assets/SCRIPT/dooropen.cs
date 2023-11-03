using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    // adding door open gameobject and door closed gameobject
    public CharacterController characterController;
    public GameObject dooropened;
    public GameObject doorclosed;
 
 public void dooropener()
 {
        // setting dooropened when true and false 
    dooropened.SetActive(true);
    doorclosed.SetActive(false);

 }
    // if character touches the collider with key door opens
void OnTriggerEnter2D(Collider2D other)
    {
       if  (characterController.HasKey == true)
    {
      Debug.Log("dooropened");
      dooropener();
    }

    }
 
}
