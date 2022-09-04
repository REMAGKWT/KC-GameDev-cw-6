using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawnmid;
    public Transform spawnmax;
    public Transform spawnmin;

    public GameObject enemy;

    public int delay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        int RandomPos = Random.Range(-3,3);
        if (RandomPos == 1)
        {
            Instantiate(enemy, spawnmin);

        }
        else if (RandomPos == 2)
        {
            Instantiate(enemy, spawnmid);
        }
        else
        {
            Instantiate(enemy, spawnmax);
        }
    
    }
}
