using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public int supHealth;
    public int supDamage;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.health += supHealth;
            player.damage += supDamage;
            Destroy(gameObject);
        }
    }
}
