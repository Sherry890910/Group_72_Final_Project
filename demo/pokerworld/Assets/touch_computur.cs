using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_computur : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "thief")
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
