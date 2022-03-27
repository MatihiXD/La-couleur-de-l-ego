using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
     public int health;
    void Start()
    {
        
    }

    void Update()
    {
        TrailColor();
    }
    void TrailColor()
    {
        health = GameObject.FindWithTag("Player").GetComponent<Player>().health;
        if (health <= 50) {
            TrailRenderer myTrailRenderer = GetComponent<TrailRenderer>();
            myTrailRenderer.startColor = Color.red;
            myTrailRenderer.endColor = Color.white;
        }
    }
}
