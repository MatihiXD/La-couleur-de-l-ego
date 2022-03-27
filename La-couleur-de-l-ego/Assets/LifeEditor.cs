using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeEditor : MonoBehaviour
{

    public int life = 100;
    public Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        lifeText.text = life.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        life = GameObject.FindWithTag("Player").GetComponent<Player>().health;
        lifeText.text = life.ToString();
    }
}
