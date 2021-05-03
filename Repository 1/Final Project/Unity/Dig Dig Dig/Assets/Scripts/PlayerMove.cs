using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject cab;
    public float speed = 10.0f;
    public GameManager gameManager;
    private float hInput;
    private float fInput;
    public float turnSpeed = 40.0f;
    public float xRange = 28;
    public float zRange = 28;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTracks();
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(-zRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
        }

    }
    public void MoveTracks()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * fInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
    }
    IEnumerator SetBounds()
    {
        while (gameManager.isGameActive == true)
        {
            yield return new WaitForSeconds(.5f);
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(-zRange, transform.position.y, transform.position.z);
            }
            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
            }
        }
    }
}
