using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private static Image HealthBarImage;
    public float maxHp = 0;
    public float hp;
    private Transform childObj;
    public void Start()
    {
        HealthBarImage = GetComponent<Image>();
        maxHp = GameObject.FindWithTag("Boss").GetComponent<Boss>().life;
        childObj = transform.Find("BossName");
    }

    public void Update()
    {
        if (GameObject.FindWithTag("Boss").GetComponent<Boss>().IsFighting == false){
            hp = 0;
        } else {
            hp = GameObject.FindWithTag("Boss").GetComponent<Boss>().life;
            childObj.gameObject.SetActive(true);
        }
        SetHealthBarValue();
    }

    public void SetHealthBarValue()
    {
        float value = hp / maxHp;
        Debug.Log(value);
        HealthBarImage.fillAmount = value;
    }
}
