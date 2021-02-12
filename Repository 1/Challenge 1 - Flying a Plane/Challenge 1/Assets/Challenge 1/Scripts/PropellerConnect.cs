using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerConnect : MonoBehaviour
{
    public GameObject Plane;
    public Vector3 offset = new Vector3(0,0,4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Plane.transform.position + offset;
    }
}
