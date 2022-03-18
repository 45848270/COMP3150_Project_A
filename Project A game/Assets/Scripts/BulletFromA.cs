using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFromA : MonoBehaviour
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
        if (Input.GetButton(InputAxes.AFireUp) && !Input.GetButton(InputAxes.AFireDown))
        {
            isFireUp = true;
        }

        if (Input.GetButton(InputAxes.AFireDown) && !Input.GetButton(InputAxes.AFireUp))
        {
            isFireDown = true;
        }

        if (Input.GetButton(InputAxes.AFireLeft) && !Input.GetButton(InputAxes.AFireRight))
        {
            isFireLeft = true;
        }

        if (Input.GetButton(InputAxes.AFireRight) && !Input.GetButton(InputAxes.AFireLeft))
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
