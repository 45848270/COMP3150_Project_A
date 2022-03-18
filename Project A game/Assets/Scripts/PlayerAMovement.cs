
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerAMovement : MonoBehaviour
{
    public int playerASpeed = 3;
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
        PlayerAMoves();
    }
    void PlayerAMoves()
    {
        if (Input.GetButton(InputAxes.PlayerAMoveUp))
        {
            if ((this.transform.position.y + (this.transform.localScale.y) / 2) < cameraTopSide)
            {
                PlayerMoveUp();
            }
        }
        if (Input.GetButton(InputAxes.PlayerAMoveDown))
        {
            if ((this.transform.position.y - (this.transform.localScale.y) / 2) > cameraBottomSide)
            {
                PlayerAMoveDown();
            }
        }
        if (Input.GetButton(InputAxes.PlayerAMoveLeft))
        {
            if ((this.transform.position.x - (this.transform.localScale.x) / 2) > cameraLeftSide)
            {
                PlayerAMoveLeft();
            }
        }
        if (Input.GetButton(InputAxes.PlayerAMoveRight))
        {
            if ((this.transform.position.x + (this.transform.localScale.x) / 2) < cameraRightSide)
            {
                PlayerAMoveRight();
            }
        }
    }
    void PlayerMoveUp()
    {
        this.transform.Translate(upWard * Time.deltaTime * playerASpeed);
    }
    void PlayerAMoveDown()
    {
        this.transform.Translate(downWard * Time.deltaTime * playerASpeed);
    }
    void PlayerAMoveLeft()
    {
        this.transform.Translate(leftWard * Time.deltaTime * playerASpeed);
    }
    void PlayerAMoveRight()
    {
        this.transform.Translate(rightWard * Time.deltaTime * playerASpeed);
    }
}
