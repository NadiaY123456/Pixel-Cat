using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitMove : MonoBehaviour
{
    // Start is called before the first frame update

    private float startDelay = 1;
    private float repeatRate = 1;

    public AudioSource source;
    public AudioClip clip;

    
    void Start()
    {
        InvokeRepeating("moveFruit",startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("player")) {
            Destroy(gameObject);
            ScoreMonitor.instance.AddPoint();
            source.PlayOneShot(clip);

            //Debug.Log("hai :3");
            //dirtParticle.Play(); 
        } 

        

            
    }

    IEnumerator moveFruit() {
        Debug.Log("hey");
        yield return new WaitForSeconds((float)0.2);
        transform.position = (Vector2) transform.position + new Vector2((float)0.5, 0);
        yield return new WaitForSeconds((float)0.2);
        transform.position = (Vector2) transform.position + new Vector2((float)0.5, 0);
        yield return new WaitForSeconds((float)0.2);
        transform.position = (Vector2) transform.position - new Vector2((float)0.5, 0);
        yield return new WaitForSeconds((float)0.2);
        transform.position = (Vector2) transform.position - new Vector2((float)0.5, 0);


    }
}
