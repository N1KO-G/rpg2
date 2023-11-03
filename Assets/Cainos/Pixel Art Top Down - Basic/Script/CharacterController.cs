using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
    {
        
     // setting variables
     public Weapon weapon;
    public int respawn;
    public bool HasKey = false;
    public float dashspeed;
    
        public float speed;

        private Animator animator;
        private GameManager gameManager;

        public Rigidbody2D rb;
        
        Vector2 movement;
        Vector2 mousePosition;

    [SerializeField] private AudioSource dashsound;
    

    public int maxhealth = 10;
    public int health;

        private void Start()
        {
        // setting health and getting animator and gamemanager
        health = maxhealth;
            animator = GetComponent<Animator>();

             gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        }


        public void Update()
        {
        // getting the movement and making it able to move
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {

            rb.velocity = new Vector2(dir.x * speed * dashspeed, dir.y * speed * dashspeed);
            
            


            }

        dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;

        // dash code
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            rb.velocity = new Vector2( dir.x  * speed * dashspeed, dir.y * speed * dashspeed);
            


        }


    }

    // taking damage from enemy
    public void takedamage(int enemydamage)
    {
        health -= enemydamage;
        if (health <= 0)
        {
            SceneManager.LoadScene(respawn);
        }
    }


    // collect coin when you enter
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Coin")
            {
                gameManager.coinsCounter += 1;
                Destroy(other.gameObject);
                Debug.Log("Player has collected a coin!");
            }
        
        
    }

    



}

