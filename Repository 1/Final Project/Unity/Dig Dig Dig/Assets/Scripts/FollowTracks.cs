using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTracks : MonoBehaviour
{
    private Vector3 offsetMain = new Vector3(.35f,1.12f,1.255f);
    public float speed;
    public GameObject tracks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (tracks.transform.position - transform.position);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(lookDirection, horizontalInput * speed * Time.deltaTime);
        transform.position = tracks.transform.position + offsetMain;
    }
}
