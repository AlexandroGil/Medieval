using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
          transform.Rotate(0.0f, 0.0f, 1.0f);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
          transform.Rotate(0.0f, 0.0f, -1.0f);
        }
    }
}
