using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet : MonoBehaviour
{

    private Vector3 mousePos;
    private Camera cam;
    private Rigidbody2D rb;
    public float force;
    
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // enemy take damage

        if(collision.gameObject.TryGetComponent<enemy>(out enemy enemycomponent))
        {
            enemycomponent.TakeDamage(1);
        }

            Destroy(gameObject);
    }
}
