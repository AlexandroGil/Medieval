using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCannon : MonoBehaviour
{
    public GameObject cannon;

    void Update()
    {
        Vector3 direction = cannon.transform.position;
        direction.y = transform.position.y;
        transform.LookAt(direction);
    }
}
