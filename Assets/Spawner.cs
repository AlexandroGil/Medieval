using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Castle;
    public Transform Cspawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.Q)))
            {
                Instantiate(Castle, Cspawner.position, Quaternion.identity);
            }
    }
}
