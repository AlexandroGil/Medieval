using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTrackingEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        Transform[] children = GetComponentsInChildren<Transform>(true);

        foreach (Transform child in children)
        {
            if (child != transform && child.parent == transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    protected override void OnTrackingLost()
    {
        Transform[] children = GetComponentsInChildren<Transform>(true);

        foreach (Transform child in children)
        {
            if (child != transform && child.parent == transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
