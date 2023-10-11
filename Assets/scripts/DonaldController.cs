using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DonaldController : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = 10;
    }


    private void Update()
    {
        if(Input.GetKey(KeyCode.H))
        {
            Vector3 newPosition = transform.position + new Vector3(speed*Time.deltaTime, 0, 0);

            transform.position = newPosition;

        }
        if(Input.GetKey(KeyCode.F))
        {
            Vector3 newPosition = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);

            transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.T))
        {
            Vector3 newPosition = transform.position + new Vector3(0, speed * Time.deltaTime, 0);

            transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.G))
        {
            Vector3 newPosition = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);

            transform.position = newPosition;

        }
        if (transform.position.x > 10)
        {
            Vector3 newPosition = transform.position + new Vector3(-1,0,0);

            transform.position = newPosition;
        }
        if (transform.position.x < -10)
        {
            Vector3 newPosition = transform.position + new Vector3(1, 0, 0);

            transform.position = newPosition;
        }
         if(transform.position.y > 5)
        {
            Vector3 newPosition = transform.position + new Vector3(0, -1, 0);

            transform.position = newPosition;
        }
        
       

        if(Input.GetKey(KeyCode.Y))
        {
            speed = speed + 1* Time.deltaTime;
        }
    }
}
