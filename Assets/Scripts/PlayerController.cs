using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector2.right * speed * playerInput * Time.deltaTime);
    }
}
