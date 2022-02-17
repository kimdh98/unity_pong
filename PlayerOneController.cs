using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    private float moveSpeed = 10.0f;
    private Vector2 direction;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            direction = Vector2.up;
        }
        else if (Input.GetKey("s")) {
            direction = Vector2.down;
        }
        else {
            direction = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        rb2d.AddForce(direction * moveSpeed);
    }

    public void reset()
    {
        rb2d.position = new Vector2(-10.0f, 0.0f);
    }
}
