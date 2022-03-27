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
        player =  GameObject.FindWithTag("Player");
        damage =  GameObject.FindWithTag("Boss").GetComponent<Boss>().damage;
        Vector3 mousePosition = player.transform.position;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        rb.velocity = direction * speed;
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
