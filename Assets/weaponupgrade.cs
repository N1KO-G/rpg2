using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponupgrade : MonoBehaviour
{
    public shooting shootbang;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        shootbang.upgrade = true;
        
        Destroy(gameObject);
    }
}
