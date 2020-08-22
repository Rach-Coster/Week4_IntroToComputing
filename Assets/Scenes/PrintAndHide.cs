using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend; 
    private int i;
    private int rand; 

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        rand = rnd.Next(200, 251);

        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && i == rand)
        {
            rend.enabled = false;
        }

        print(gameObject.name + ":"+ i);
        i++;
    }
}
 