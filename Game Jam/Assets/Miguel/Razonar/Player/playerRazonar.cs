using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float yMin, yMax;
}

public class playerRazonar : MonoBehaviour {
    public float speed;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    private Vector3 inicialPosition;

    private void Start()
    {
        inicialPosition = transform.position;
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(0.0f, moveVertical, 0.0f);

        GetComponent<Rigidbody>().velocity = movement * speed;

        transform.position = new Vector3
        (
            inicialPosition.x,
            Mathf.Clamp (transform.position.y, boundary.yMin, boundary.yMax),
            inicialPosition.z
        ); 
    }

    private void Update()
    {
        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
