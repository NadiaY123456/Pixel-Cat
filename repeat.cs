using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 startPos;
    private float repeatWidth;
    public Rigidbody2D rb;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<SpriteRenderer>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.transform.position.x > transform.position.x - repeatWidth) {
            transform.position = (Vector2) transform.position + new Vector2(repeatWidth * 2, 0);
        }
    }
}
