using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    void Start() {
    }
    void OnMouseDown() {
        this.GetComponent<Cannon>().enabled = true;
        transform.Find("CannonCamera").gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
