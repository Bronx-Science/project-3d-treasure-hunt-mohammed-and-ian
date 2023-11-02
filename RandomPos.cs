using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomPos : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] spawns = { new Vector3(0, 0, 0), new Vector3(1, 0, 0), new Vector3(2, 0, 0), new Vector3(3, 0, 0), new Vector3(4, 0, 0) };
        GameObject treasure1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //GameObject treasure2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject treasure3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject treasure4 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        //GameObject treasure5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject[] treasures = { treasure1, null, treasure3, treasure4, null};
        Randomize(treasures);
        for (int i = 0; i < treasures.Length; i++)
        {
            if (treasures[i] != null)
            {
                treasures[i].transform.position = spawns[i];
            }
        }
    }

    public static void Randomize<GameObject>(GameObject[] items)
    {
        System.Random rand = new System.Random();

        // For each spot in the array, pick
        // a random item to swap into that spot.
        for (int i = 0; i < items.Length - 1; i++)
        {
            int j = rand.Next(i, items.Length);
            GameObject temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
