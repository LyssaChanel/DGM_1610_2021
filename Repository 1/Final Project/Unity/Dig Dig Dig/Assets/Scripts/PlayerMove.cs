using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // public GameObject armMain;
    // public GameObject armFore;
    // public GameObject armBucket;
    public GameObject cab;
    // private GameObject armMain_Fp;
    // private GameObject armFore_Fp;
    // private GameObject armBucket_Fp;
    public float speed = 10.0f;
    private float hInput;
    private float fInput;
    public float turnSpeed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * fInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
    }
}
