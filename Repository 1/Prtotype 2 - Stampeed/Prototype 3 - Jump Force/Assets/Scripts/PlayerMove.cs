using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip crashSound;
    public AudioClip jumpSound;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    // Start is called before the first frame update
    // PHYSICSSSSSS
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        if (!dirtParticle.isPlaying) {
        dirtParticle.Play();
        }
        
    }

    // Update is called once per frame
    //when space bar is pressed, player will jump
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            if (dirtParticle.isPlaying) {
            dirtParticle.Stop();
            }
            playerAudio.PlayOneShot(jumpSound);
        }
    }
    //If player runs into obstacle, they fall over and die
    void OnCollisionEnter(Collision collision)
    {
         Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            Debug.Log("Game Over!!!");
            explosionParticle.Play();
            if (dirtParticle.isPlaying) {
            dirtParticle.Stop();
            }
            if (gameOver == true){
                playerAudio.PlayOneShot(crashSound);
            }
        }
        else if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            if (!dirtParticle.isPlaying) {
            dirtParticle.Play();
            }
        }
    }
}
