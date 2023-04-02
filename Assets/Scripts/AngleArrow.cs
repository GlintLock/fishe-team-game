using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleArrow : MonoBehaviour
{
    public GameObject playerCenter;
    public GameObject projectilePrefab;
    [SerializeField] Transform projectileSpawnPos;
    public float rotateSpeed = 10.0f;

    public float launchPower = 0;
    private float timeStep = 0.05f;
    private int stepCount = 15;
    private float launchDirection;


    private Vector2 velocity;

    

    // Start is called before the first frame update
    void Start()
    {
        playerCenter = GameObject.Find("Player2");
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, playerInput * rotateSpeed);
        if (Input.GetKeyDown("z") && launchPower > 0)
        {
            launchPower -= 5;
        }
        if (Input.GetKeyDown("x") && launchPower < 100)
        {
            launchPower += 5;
        }
        if (Input.GetKeyDown("space"))
        {
            FireProjectile();
        }

        
    }
    void FireProjectile()
    {
        GameObject pr = Instantiate(projectilePrefab, projectileSpawnPos.position, Quaternion.identity);
        
        pr.GetComponent<Rigidbody2D>().velocity = velocity;

    }
}
