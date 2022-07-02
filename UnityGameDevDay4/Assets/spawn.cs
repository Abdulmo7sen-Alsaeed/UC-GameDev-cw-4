using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject greenObject;
    public GameObject redObject;
    void Spawn() {
        GameObject spawnObject;
        GameObject spawnPosition;
        int choice = Random.Range(0, 2);
        if (choice == 0)
            spawnObject = greenObject;
        else
            spawnObject = redObject;

        // to choose which obstacle is spawned
        int newPosition = Random.Range(-1, 2);
        Vector3 vPosition = transform.position;
        vPosition.x = vPosition.x + (7* newPosition);

        spawnPosition = Instantiate(spawnObject,vPosition,Quaternion.identity);

    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
