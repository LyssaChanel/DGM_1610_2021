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
        
    }
}
