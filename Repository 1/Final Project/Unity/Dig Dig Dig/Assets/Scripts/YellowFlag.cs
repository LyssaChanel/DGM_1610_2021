using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowFlag : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem shockParticle;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.UpdateScore(pointValue);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Bucket"))
        {
            Debug.Log("Uh oh!");
            Destroy(gameObject);
            Instantiate(shockParticle, transform.position, shockParticle.transform.rotation);
            gameManager.GameOver();
        }
    }
}
