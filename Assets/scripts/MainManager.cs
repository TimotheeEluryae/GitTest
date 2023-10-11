using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public int[] myArray;
    public int count;

    private void Start()
    {
        myArray = new int[count]; 
        
        for (int i = 0; i < count; i++)
        {
            myArray[i] = i;
        }
    }
}
