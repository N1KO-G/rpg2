using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class padpress : MonoBehaviour
{

    private chestopen chestopen;

     public void OnTriggerEnter2D(Collider2D other)
        {
            chestopen.chestopener();
        }
}
