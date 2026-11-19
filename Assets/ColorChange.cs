using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    //this script should change color of the SpriteRenderer
    //Color should be calculated from holding time 
    //If player doesnt hold any thing color should move to normal

    private SpriteRenderer spriteRender;

    public float maxHoldTime = 2;
    private float currentHoldTime;

    public float holdTimeSpeed = 1; 

    public Gradient gradient;


    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (currentHoldTime < maxHoldTime)
            {
                currentHoldTime += Time.deltaTime * holdTimeSpeed;
                spriteRender.color = gradient.Evaluate(currentHoldTime / maxHoldTime);
            }
           
        }
        else
        {
            if(currentHoldTime > 0)
            {
                currentHoldTime -= Time.deltaTime * holdTimeSpeed;
                spriteRender.color = gradient.Evaluate(currentHoldTime / maxHoldTime);
            }
            
        }
        
            



        //spriteRender.color = gradient.Evaluate();
    }
    
}
