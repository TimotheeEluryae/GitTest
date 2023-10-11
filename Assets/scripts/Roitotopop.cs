using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Roitoto : MonoBehaviour
{

    public GameObject rototo;
    public bool activates;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(activates)
        {
            rototo.SetActive(false);


        }
        else
        {
            rototo.SetActive(true);

        }

    }
}
