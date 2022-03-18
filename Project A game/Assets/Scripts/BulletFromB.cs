using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFromB : MonoBehaviour
{
    private bool isFireUp;
    private bool isFireDown;
    private bool isFireLeft;
    private bool isFireRight;
    public float BulletSpeed = 6;



    // Start is called before the first frame update
    void Start()
    {
        isFireUp = false;
        isFireDown = false;
        SetFireDirection();
    }

    void Update()
    {
        BulletMoves();

    }


    void SetFireDirection()
    {
        if (Input.GetButton(InputAxes.BFireUp) && !Input.GetButton(InputAxes.BFireDown))
        {
            isFireUp = true;
        }

        if (Input.GetButton(InputAxes.BFireDown) && !Input.GetButton(InputAxes.BFireUp))
        {
            isFireDown = true;
        }

        if (Input.GetButton(InputAxes.BFireLeft) && !Input.GetButton(InputAxes.BFireRight))
        {
            isFireLeft = true;
        }

        if (Input.GetButton(InputAxes.BFireRight) && !Input.GetButton(InputAxes.BFireLeft))
        {
            isFireRight = true;
        }
    }

    void BulletMoves()
    {
        if (isFireUp)
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector3.up);
        }

        if (isFireDown)
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector3.down);
        }

        if (isFireLeft)
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector3.left);
        }

        if (isFireRight)
        {
            transform.Translate(BulletSpeed * Time.deltaTime * Vector3.right);
        }
    }
}
