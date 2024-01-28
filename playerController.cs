using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public bool isOnGround = true;
    public int jumpStrength = 1000;
    public GameObject game_over;



    public Animator playerAnim;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !gameOver) {

            rb.velocity = new Vector2(3, rb.velocity.y);

        } /*else if (Input.GetKey(KeyCode.LeftArrow) && !gameOver){
            rb.velocity = new Vector2(-3, rb.velocity.y);

        }*/ else if ((Input.GetKey(KeyCode.UpArrow)) && isOnGround && !gameOver){
            rb.AddForce(new Vector2(0, jumpStrength));
            isOnGround = false;

            playerAnim.SetBool("jump1", true);
            //Debug.Log("hi");
            //isJumping = true;

        }

        if(rb.velocity.magnitude > 0) {
            playerAnim.SetBool("walk1", true);
        } else {
            playerAnim.SetBool("walk1", false);
        }


        //sJumping = false;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("ground")) {
            isOnGround = true;
            playerAnim.SetBool("jump1", false);
            //Debug.Log("hi");
            //Debug.Log("hai :3");
            //dirtParticle.Play(); 
        }

        if (collision.gameObject.CompareTag("die")) {
            gameOver = true;
            playerAnim.SetBool("over", true);
            transform.Rotate(new Vector3(180, 0, 0));
            game_over.gameObject.transform.position = transform.position;
            game_over.gameObject.SetActive(true);
        

            //Debug.Log("hai :3");
            //dirtParticle.Play(); 
        } 

        

            
    }
}
