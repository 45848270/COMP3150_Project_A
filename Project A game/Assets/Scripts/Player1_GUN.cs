using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_GUN : MonoBehaviour
{
    //Setting the variables

    public Transform initialPos;
    public GameObject bulletPrefabs;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(InputAxis.b1DirX) || Input.GetButtonDown(InputAxis.b1DirY))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefabs, initialPos.position, initialPos.rotation);
    }
}
