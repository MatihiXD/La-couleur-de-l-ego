using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Update()
    {
        if (gameObject.GetComponent<Boss>().IsFighting == true)
        {
            shoot();
        }
    }

    // Update is called once per frame
    public void shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
