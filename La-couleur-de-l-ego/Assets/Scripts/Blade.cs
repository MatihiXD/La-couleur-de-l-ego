using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody2D rb;
    public int damage = 100;
    private GameObject player;
    // Focus on the player position
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb.rotation = 2;
        rb.velocity = (player.transform.position - transform.position).normalized * speed;
    }

    void Update()
    {
        rb.rotation += 4;
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
