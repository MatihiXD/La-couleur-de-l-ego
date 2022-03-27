using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    public int health;

    void Start()
    {
    }

    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        health = GameObject.FindWithTag("Player").GetComponent<Player>().health;
        if (health <= 50) {
            Debug.Log("injured");
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient( Color.red );
        }   else {
            ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
            settings.startColor = new ParticleSystem.MinMaxGradient( Color.white );
        }
    }
}
