using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {
    [SerializeField] private float speedZ;
    [SerializeField] private float speedX;
    Rigidbody rb;
    private void Awake()
    {
       rb = GetComponent<Rigidbody>();
    }
   
    private void PMov()
    {
        rb.velocity = (new Vector3(Input.acceleration.x * speedX, 0, speedZ));
    }
    private void FixedUpdate()
    {
        PMov();
    }
}
