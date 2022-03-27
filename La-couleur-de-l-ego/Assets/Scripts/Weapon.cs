using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float fireRate = 0.5f;

    public bool isFiring = true;
    // Start is called before the first frame update

    void Start()
    {
        fireRate = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().fireRate;
    }

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
