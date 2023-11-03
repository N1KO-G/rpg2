using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    
   // setting navmesh agent and all variables
    NavMeshAgent agent;
    
    public GameObject player;
    public float speed;
    public float distancebetween;
    private float distance;
    private Animator animator;
    private GameManager gameManager;
    [SerializeField] float health, maxhealth = 3f;
    [SerializeField] private AudioSource deathsound;
    public float timebetweenattack;
    public bool canattack;
    private float timer;

    public int enemydamage;
    public CharacterController playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        // getting navmesh agent and also getting health and gamemanager
      var agent = GetComponent<NavMeshAgent>();
		agent.updateRotation = false;
		agent.updateUpAxis = false;
      

        health = maxhealth;
           animator = GetComponent<Animator>();

            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // enemy move towards player when at a certain distance
       
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        if (distancebetween > distance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // enemy damages player with tickdamage on a timer
        if(collision.gameObject.tag == "Player")
        {
            if (!canattack)
            {

                timer += Time.deltaTime;
                if (timer > timebetweenattack)
                {

                    canattack = true;
                    timer = 0;
                }
            }
            if (canattack)
            {

                playerHealth.takedamage(enemydamage);
                canattack = false;
            }
            
            
            
        }
    }
    // if health is 0 enemy dies and is destroyed
    public void TakeDamage(float damageamount)
    {
        health -= damageamount;
        if (health <= 0)
        {
            
            Destroy(gameObject);
            

        }
    }
}
