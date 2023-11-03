using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killplayer : MonoBehaviour
{
    // setting the respawn variable
    public int respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // when player touches collider gets respawned
    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(respawn);
        }
    }
}
