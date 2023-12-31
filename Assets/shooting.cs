using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // setting variables
    [SerializeField] private AudioSource shootsound;
    public bool canfire;
    private float timer;
    public Camera cam;
    private Vector3 mousePosition;
    public float timebetweenfiring;
    public Transform weapon;
    public GameObject bullet;
    public bool upgrade;

void Start()
{
        //getting the camera
    cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
}

void Update()
{
        // making the gun aim at the mouse position
    mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

    Vector3 rotation = mousePosition - transform.position;

    float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

    transform.rotation = Quaternion.Euler(0, 0, rotZ);
        // checking if player can fire with timer
        if(!canfire)
        {

            timer += Time.deltaTime;
            if(timer > timebetweenfiring)
            {
                
                canfire = true;
                timer = 0;
            }
        }
        // shooting on buttonclick and canfire variable true
        if (Input.GetMouseButtonDown(0) && canfire)
        {
            shootsound.Play();
            canfire = false;

            GameObject Currentbullet = Instantiate(bullet, weapon.position, Quaternion.identity);
            
            if (upgrade)
            {
                Currentbullet.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
            }
        }
}


}
