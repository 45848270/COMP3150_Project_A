using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // setting the public variables
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(InputAxis.Player1_X_dir);
        float y = Input.GetAxis(InputAxis.Player1_y_dir);

        transform.Translate(x * speed * Time.deltaTime * Vector2.right);
        transform.Translate(y * speed * Time.deltaTime * Vector2.up);
    }
}
