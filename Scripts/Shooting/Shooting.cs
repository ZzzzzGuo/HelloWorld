using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed = 10f;

    private Inventory inventory;
    // Use this for initialization
    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.ammo.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.ammo.bullets--;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
