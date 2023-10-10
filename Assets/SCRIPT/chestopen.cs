using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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
