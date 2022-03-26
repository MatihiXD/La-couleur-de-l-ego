using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishDamage : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(transform.parent.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
