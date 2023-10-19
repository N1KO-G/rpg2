using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    public CharacterController characterController;
    public GameObject dooropened;
    public GameObject doorclosed;
 
 public void dooropener()
 {
    dooropened.SetActive(true);
    doorclosed.SetActive(false);

 }
void OnTriggerEnter2D(Collider2D other)
    {
       if  (characterController.HasKey == true)
    {
      Debug.Log("dooropened");
      dooropener();
    }

    }
 
}
