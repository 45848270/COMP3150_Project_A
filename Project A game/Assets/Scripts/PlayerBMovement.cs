
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBMovement : MonoBehaviour
{
    public int playerBSpeed = 3;
    private Vector3 upWard;
    private Vector3 downWard;
    private Vector3 leftWard;
    private Vector3 rightWard;
    private float distanceFromTopSide;
    private float distanceFromDownSide;
    private float distanceFromLeftSide;
    private float distanceFromRightSide;
    private float cameraTopSide;
    private float cameraBottomSide;
    private float cameraLeftSide;
    private float cameraRightSide;



    void Start()
    {
        upWard = new Vector3(0, 1, 0);
        downWard = new Vector3(0, -1, 0);
        leftWard = new Vector3(-1, 0, 0);
        rightWard = new Vector3(1, 0, 0);

        cameraTopSide = Camera.main.orthographicSize;
        cameraBottomSide = -1 * Camera.main.orthographicSize;
        cameraLeftSide = -1 * cameraTopSide * Camera.main.aspect;
        cameraRightSide = cameraTopSide * Camera.main.aspect;
    }

    void Update()
    {
        PlayerBMoves();
    }
    void PlayerBMoves()
    {
        if (Input.GetButton(InputAxes.PlayerBMoveUp))
        {
            if ((this.transform.position.y + (this.transform.localScale.y) / 2) < cameraTopSide)
            {
                PlayerBMoveUp();
            }
        }
        if (Input.GetButton(InputAxes.PlayerBMoveDown))
        {
            if ((this.transform.position.y - (this.transform.localScale.y) / 2) > cameraBottomSide)
            {
                PlayerBMoveDown();
            }
        }
        if (Input.GetButton(InputAxes.PlayerBMoveLeft))
        {
            if ((this.transform.position.x - (this.transform.localScale.x) / 2) > cameraLeftSide)
            {
                PlayerBMoveLeft();
            }
        }
        if (Input.GetButton(InputAxes.PlayerBMoveRight))
        {
            if ((this.transform.position.x + (this.transform.localScale.x) / 2) < cameraRightSide)
            {
                PlayerBMoveRight();
            }
        }
    }
    void PlayerBMoveUp()
    {
        this.transform.Translate(upWard * Time.deltaTime * playerBSpeed);
    }
    void PlayerBMoveDown()
    {
        this.transform.Translate(downWard * Time.deltaTime * playerBSpeed);
    }
    void PlayerBMoveLeft()
    {
        this.transform.Translate(leftWard * Time.deltaTime * playerBSpeed);
    }
    void PlayerBMoveRight()
    {
        this.transform.Translate(rightWard * Time.deltaTime * playerBSpeed);
    }
}
