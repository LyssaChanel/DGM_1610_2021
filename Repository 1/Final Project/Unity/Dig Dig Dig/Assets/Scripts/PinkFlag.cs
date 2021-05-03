using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkFlag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem waterParticle;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
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
            gameManager.UpdateScore(pointValue);
        }
    }
}
