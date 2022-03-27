using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        bullet bullet = hitInfo.GetComponent<bullet>();
        if (bullet != null)
        {
            SceneManager.LoadScene("Scenes/Win");
        }
    }
}
