using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float Speed = 0;
    public static float factor = 0f;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,-Speed * factor * Time.deltaTime));
    }

    public void UpdateFactor()
    {
        factor = slider.value;
    }
}
