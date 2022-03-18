using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBFire : MonoBehaviour
{
    public float createBulletPeriod = 0.5f;
    private float createBulletTimer;

    public GameObject bulletPrefab;
    private bool isFiring;


    // Start is called before the first frame update
    void Start()
    {
        createBulletTimer = createBulletPeriod;
        isFiring = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfIsFiring();


        if (isFiring)
        {
            BulletCounterDecreases();
        }


        if (createBulletTimer <= 0)
        {
            Fire();
        }
    }

    void CheckIfIsFiring()
    {
        if (Input.GetButton(InputAxes.BFireUp) && !Input.GetButton(InputAxes.BFireDown))
        {
            isFiring = true;
        }

        else if (Input.GetButton(InputAxes.BFireDown) && !Input.GetButton(InputAxes.BFireUp))
        {
            isFiring = true;
        }
        else if (Input.GetButton(InputAxes.BFireLeft) && !Input.GetButton(InputAxes.BFireRight))
        {
            isFiring = true;
        }
        else if (Input.GetButton(InputAxes.BFireRight) && !Input.GetButton(InputAxes.BFireLeft))
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }
    }

    void BulletCounterDecreases()
    {
        createBulletTimer -= Time.deltaTime;
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
        createBulletTimer = createBulletPeriod;
    }

}
