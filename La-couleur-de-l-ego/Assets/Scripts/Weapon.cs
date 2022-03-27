using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float fireRate = 0.5f;

    public bool isFiring = true;
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnCLick();
        }
    }
    public void OnCLick()
    {
        if (isFiring == true)
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
