using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private static Image HealthBarImage;
    public int maxHp = 0;
    public void Start()
    {
        HealthBarImage = GetComponent<Image>();
        maxHp = GameObject.FindWithTag("Boss").GetComponent<Boss>().life;
    }

    public void Update()
    {
        SetHealthBarValue();
    }

    public void SetHealthBarValue()
    {
        int hp = GameObject.FindWithTag("Boss").GetComponent<Boss>().life;
        float value = maxHp * 100 / hp;
        HealthBarImage.fillAmount = value;
    }
}
