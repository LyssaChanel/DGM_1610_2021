﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowFlag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem shockParticle;
    public AudioClip explosion;
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
            gameManager.UpdateScore(pointValue);
            Debug.Log("Uh oh!");
            flagAudio.PlayOneShot(explosion, 1.0f);
            Destroy(gameObject);
            shockParticle.Play();
            gameManager.GameOver();
        }
    }
}