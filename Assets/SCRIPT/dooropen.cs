using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    public GameObject dooropened;
    public GameObject doorclosed;
 
 public void dooropener()
 {
    dooropened.SetActive(true);
    doorclosed.SetActive(false);
 }
}
