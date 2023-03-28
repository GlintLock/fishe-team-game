using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleArrow : MonoBehaviour
{
    public GameObject playerCenter;
    public float rotateSpeed = 10.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        playerCenter = GameObject.Find("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, playerInput * rotateSpeed);

        
    }
}
