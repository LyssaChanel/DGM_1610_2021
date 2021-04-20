using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArmMain : MonoBehaviour
{
    private bool armMainUp;
    private bool armMainDown;
    public float rotationSpeed = 5;
    private Rigidbody armMainRb;
    public GameObject focalPoint;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        armMainRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        armMainDown = Input.GetKey(KeyCode.S);
        armMainUp = Input.GetKey(KeyCode.W);
        if (armMainUp) {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if (armMainUp) {
            transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        }
    }
}
