using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public GameObject particle;
    public AudioClip soundFX;
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
            flagAudio.PlayOneShot(soundFX);
            gameManager.UpdateScore(pointValue);
            Instantiate(particle, new Vector3(transform.position.x, 2, transform.position.z), transform.rotation);
            gameManager.GameOver();
            Destroy(gameObject);
        }
        
    }
}

