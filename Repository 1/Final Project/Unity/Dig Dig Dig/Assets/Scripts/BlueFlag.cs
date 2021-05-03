using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFlag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public GameObject particle;
    public AudioClip water;
    private AudioSource flagAudio;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        flagAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Uh oh!");
        if (collision.gameObject.CompareTag("Bucket"))
        {
            flagAudio.PlayOneShot(water);
            gameManager.UpdateScore(pointValue);
            Instantiate(particle, transform.position, transform.rotation);
            Debug.Log("weeeeeeee");
            gameManager.GameOver();
        }
        
    }
}
