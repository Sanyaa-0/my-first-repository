using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public.float speed = 1;
    public.float jumpforce = 5;

    Rigidbode2D rb;
    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        sr = GetComponent <SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime

            if (input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f) 
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);

        sr.flipX = movement < 0 ? true : false;
    }
}
