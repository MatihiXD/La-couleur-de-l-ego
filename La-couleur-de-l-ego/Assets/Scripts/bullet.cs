using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public int damage = 100;
    public GameObject player;
    public GameObject ExplosionPrefab;
    // Start is called before the first frame update

    //set the bullet's direction and angle to the mouse cursor's position
    void Start()
    {
        damage = GameObject.FindWithTag("Player").GetComponent<Player>().damage;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        rb.velocity = direction * speed;
    }
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Ennemy enemy = hitInfo.GetComponent<Ennemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        BigFishDamage bigFish = hitInfo.GetComponent<BigFishDamage>();
        if (bigFish != null)
        {
            bigFish.TakeDamage(damage);
        }
        Boss boss = hitInfo.GetComponent<Boss>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }
        if (hitInfo.GetComponent<Player>() == null && hitInfo.GetComponent<FollowAreaBigFish>() == null && hitInfo.GetComponent<BossFight>() == null) {
            Instantiate(ExplosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
