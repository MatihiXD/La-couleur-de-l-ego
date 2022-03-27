using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float fireRate = 0.5f;

    private bool isFiring = true;

    // Start is called before the first frame update
    void Update()
    {
        if (gameObject.GetComponent<Boss>().IsFighting == true && isFiring == true)
        {
            StartCoroutine(shoot());
        }
    }

    // Update is called once per frame
    public IEnumerator shoot()
    {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            isFiring = false;
            yield return new WaitForSeconds(fireRate);
            isFiring = true;
    }
}
