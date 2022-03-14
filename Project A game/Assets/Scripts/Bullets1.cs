using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets1 : MonoBehaviour
{
    //Setting the variables

    public float bulletSpeed = 4f;
    public Rigidbody2D bullet;

    private float x_Dir;
    private float y_Dir;



    // Start is called before the first frame update
    void Start()
    {
        x_Dir = Input.GetAxis(InputAxis.b1DirX);
        y_Dir = Input.GetAxis(InputAxis.b1DirY);

        bullet.velocity = ((transform.up * y_Dir) + (transform.right * x_Dir)) * bulletSpeed;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log(hit.name);
        Destroy(gameObject);
    }
}
