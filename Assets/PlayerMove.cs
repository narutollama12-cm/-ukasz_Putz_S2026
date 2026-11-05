using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public SpriteRenderer sprite;
    public float MovementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + Time.deltaTime * horizontal * MovementSpeed, transform.position.y, transform.position.z);


        float vertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x , transform.position.y + Time.deltaTime * vertical * MovementSpeed, transform.position.z);



        







    }
}
