﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private WeaponManager weapon_Manager;
    public float fireRate = 15f;
    private float nextTimeToFire;
    public float damage = 20f;

    void Awake() {
        weapon_Manager = GetComponent<WeaponManager>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weaponShoot();
    }

    void weaponShoot() {
        if(weapon_Manager.GetCurrentSelectedWeapon().fireType == WeaponFireType.MULTIPLE) {
            if(Input.GetMouseButton(0) && Time.time > nextTimeToFire) {
                nextTimeToFire = Time.time + 1f / fireRate;
                weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
            }
        } else {
            if(Input.GetMouseButtonDown(0)) {
                if(weapon_Manager.GetCurrentSelectedWeapon().tag == Tags.AXE_TAG) {
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
                }
                if (weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.BULLET)
                {
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
                    //BullerFired();
                }
                else
                {

                }
            }
        }
    }
}
