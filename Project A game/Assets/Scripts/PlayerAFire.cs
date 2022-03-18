using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAFire : MonoBehaviour
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
        if (Input.GetButton(InputAxes.AFireUp) && !Input.GetButton(InputAxes.AFireDown))
        {
            isFiring = true;
        }

        else if (Input.GetButton(InputAxes.AFireDown) && !Input.GetButton(InputAxes.AFireUp))
        {
            isFiring = true;
        }
        else if (Input.GetButton(InputAxes.AFireLeft) && !Input.GetButton(InputAxes.AFireRight))
        {
            isFiring = true;
        }
        else if (Input.GetButton(InputAxes.AFireRight) && !Input.GetButton(InputAxes.AFireLeft))
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
