using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// changing the chest from closed to open when status is true

public class chestopen : MonoBehaviour
{
    public GameObject chestclosed;
    public GameObject chestopened;
 
 public void chestopener()
 {
    chestopened.SetActive(true);
    chestclosed.SetActive(false);
 }
}
