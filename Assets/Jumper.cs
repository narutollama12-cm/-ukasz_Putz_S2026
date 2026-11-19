using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //This class requires RigidBody2D
    //The purpose of this class is to automatically
    //perform a jump the moment the object touches
    //the ground with random height in set range 

    public Rigidbody2D rb;

    public float maxJump = 5;
    public float minJump = 1;

    public LayerMask whatIsGround;
    public float groundCheckDistance = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter()
    {
        DoRandomJump();


    }


    //Return if ground is under object
    public bool TouchesGround()
    {
        return Physics2D.Raycast(transform.position, -transform.up, groundCheckDistance, whatIsGround);
    }

    public float Rng(float liczba)
    {
        float liczba = Random.Range(minJump, maxJump);
    }

    public void DoRandomJump()
    {
        //use Random.Range()
        if (TouchesGround)
        {
            rb.AddForce(new Vector3(0 ,liczba, 0), ForceMode.Force);
        }



    }

   
      




    


}
