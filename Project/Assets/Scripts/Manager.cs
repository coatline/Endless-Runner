using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject[] spawns;
    public GameObject spikePrefab;

    void Start()
    {
        for (int i = 0; i < spawns.Length; i++)
        {
            print(":|");
            Instantiate(spawns[i]);
        }

        for (int i = 0; i < 100; i++)
        {
            var spike = Instantiate(spikePrefab);
        }
        
        ////ground
        //Instantiate(spawns[0]);
        ////player
        //Instantiate(spawns[1]);
        ////spike
        //Instantiate(spawns[2]);
    }

    void Update()
    {

    }
}
