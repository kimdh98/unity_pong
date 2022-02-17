using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 300.0f;
    private Rigidbody2D rb2d;
    private bool resetState;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        resetState = true;
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKey("space") & resetState) {
            resetState = false;
            SetRandomInitialDirection();
        }
    }

    private void SetRandomInitialDirection()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(1.0f, 0.5f): Random.Range(-1.0f, -0.5f);
        Vector2 direction = new Vector2(x, y);
        rb2d.AddForce(direction * moveSpeed);
    }

    public void reset()
    {
        rb2d.position = new Vector2(0.0f, 0.0f);
        rb2d.velocity = new Vector2(0.0f, 0.0f);
        resetState = true;
    }
}
