using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Light : MonoBehaviour
{
    Light learning_light;
    float Lightimer = 0;
    private void Start()
    {
        learning_light = GetComponent<Light>();
    }
    private void Update()
    {
        if(this.name == "Naturalight")
        {
            Lightimer += Time.deltaTime * 1;
            if (Lightimer <= 10f)
            {
                learning_light.intensity += 0.01f;
            }
        }
        else
        {
            Lightimer += Time.deltaTime * 1;
            if (Lightimer >= 0.5f)
            {
                learning_light.intensity += 2;
                Lightimer = 0;
            }
            if (learning_light.intensity >= 3)
            {
                learning_light.intensity = 0;
            }
        }
       
    }
}
