using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;
public class RotateCab : MonoBehaviour
{
    private bool turnLeft;
    private bool turnRight;
    // private bool armMainUp;
    // private bool armMainDown;
    // private bool armForeIn;
    // private bool armForeOut;
    // private bool armBucketIn;
    // private bool armBucketOut;
    public float turnSpeed = 30.0f;
    private Vector3 offsetY = new Vector3(0,1,0);
    public GameObject tracks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If Q or A is pressed, cab will turn left or right.
       // transform.position = tracks.transform.position + offsetY;
        turnLeft = Input.GetKey(KeyCode.Q);
        turnRight = Input.GetKey(KeyCode.A);
        if (turnLeft){
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (turnRight) {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        }
    }
}
