using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeOut = 0.75f;
    private bool yesDogs = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && yesDogs)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            yesDogs = false;
            Debug.Log("Spawn a Dog");
            StartCoroutine("AllowDogs");
        }
    }
    IEnumerator AllowDogs()
    {
        yield return new WaitForSeconds(timeOut);
        yesDogs = true;
    }
}
