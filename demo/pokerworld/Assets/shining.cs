using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shining : MonoBehaviour
{
    public GameObject light_shine;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("show", 1f, 1f);
    }

    void show()
    {
        if(light_shine.activeSelf)
        {
            light_shine.SetActive(false);
        }
        else
        {
            light_shine.SetActive(true);
        }
    }
}
