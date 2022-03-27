using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int life;
    public int damage;

    public bool IsFighting = false;

    public void TakeDamage(int damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void fight()
    {
        if (IsFighting)
        {
            Debug.Log("fight");
        }
    }
}
