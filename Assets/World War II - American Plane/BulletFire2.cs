using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire2 : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }


    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);        
    }

}
