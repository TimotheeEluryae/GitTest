using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class BertrandController : MonoBehaviour
{
    public float speed;
    bool retourner; 

    private void Start()
    {
        speed = 10;
        Animator animator = GetComponent<Animator>();
        retourner = false;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 12) 
        {
            Vector3 newPosition = transform.position + new Vector3(speed*Time.deltaTime, 0, 0);

            transform.position = newPosition;

        }
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -12)
        {
            Vector3 newPosition = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);

            transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 5)
        {
            Vector3 newPosition = transform.position + new Vector3(0, speed * Time.deltaTime, 0);

            transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -5)
        {
            Vector3 newPosition = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);

            transform.position = newPosition;

        }
     
        

        if(Input.GetKey(KeyCode.U))
        {
            speed = speed + 1* Time.deltaTime;
        }
    }
}
