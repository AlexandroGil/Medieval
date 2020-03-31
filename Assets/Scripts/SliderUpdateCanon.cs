using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdateCanon : MonoBehaviour
{
    public Cannon cannon = null;
    public Slider slider = null;
    public bool setPhi = false, setTheta = false;

    void Start()
    {
        UpdateCannon();
    }

    public void UpdateCannon()
    {
        if (setPhi)
        {
            cannon.SetPhi(slider.value);
        }

        if (setTheta)
        {
            cannon.SetTheta(slider.value);
        }
    }
}
