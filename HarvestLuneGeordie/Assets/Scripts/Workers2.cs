using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Workers2 : MonoBehaviour
{


    public Transform field;
    public Transform seedHousePlot;
    public Transform bed;
    public Transform pillow;

    public GameObject AI;
    public GameObject AISeed;
    public GameObject plant;
    public GameObject plantedSeed;
    public NavMeshAgent location;

  



    void Awake()
    {
        AISeed.SetActive(false);
        location.destination = seedHousePlot.position;
        

    }


    void Update()
    {
        
        if (Vector3.Distance(transform.position, seedHousePlot.position) < 2f)
        {
            location.destination = new Vector3(UnityEngine.Random.Range(-13, 13), 0, UnityEngine.Random.Range(-14, -2));
            AISeed.SetActive(true);

        }
        if (Vector3.Distance(transform.position, location.destination) < 2f)
        {

            location.destination = pillow.position;
            Invoke("PlantingSeed", 0.0f);
            AISeed.SetActive(false);

        }
        if (Vector3.Distance(transform.position, pillow.position) < 1f)
        {
            Destroy(AI);

        }


    }

   

    void PlantingSeed()
    {
        Instantiate(plantedSeed, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
        Invoke("SeedGrowth", 10f);
    }

    void SeedGrowth()
    {
        plant.SetActive(true);
    }

}