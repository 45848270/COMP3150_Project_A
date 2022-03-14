using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Gun : MonoBehaviour
{
    //Setting the variables

    public Transform initialPos;
    public GameObject bulletPrefabs;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(InputAxis.b2DirX) || Input.GetButtonDown(InputAxis.b2DirY))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefabs, initialPos.position, initialPos.rotation);
    }
}
