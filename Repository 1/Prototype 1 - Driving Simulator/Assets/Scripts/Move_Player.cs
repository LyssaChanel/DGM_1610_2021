using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour
{
    private float speed = 5.0f;
    private float hInput;
    private float turnSpeed = 25.0f;
    private float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // Moves vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        // Allows vehicle to turn
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
        
    }
}
