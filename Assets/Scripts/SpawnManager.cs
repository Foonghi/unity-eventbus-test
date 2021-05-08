using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnALot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnALot()
    {
        for(int i = -250; i < 250; i += 5)
        {
            for(int j = -250; j < 250; j += 5)
            {
                Instantiate(enemyPrefab, new Vector3(i, 0.5f, j), Quaternion.identity);
            }
        }
    }
}
