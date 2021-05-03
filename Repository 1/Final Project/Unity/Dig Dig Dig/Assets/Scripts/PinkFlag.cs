using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkFlag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public AudioClip point;
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
        if (collision.gameObject.CompareTag("Bucket"))
        {
            Destroy(gameObject);
            flagAudio.PlayOneShot(point, 1.0f);
            gameManager.UpdateScore(pointValue);
        }
    }
}
