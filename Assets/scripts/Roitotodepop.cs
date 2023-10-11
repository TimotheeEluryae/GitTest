using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Roitotodepop : MonoBehaviour
{

    public GameObject rototo;
    public bool activates;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(activates)
        {
            rototo.SetActive(true);


        }
        else
        {
            rototo.SetActive(false);

        }

    }
}
