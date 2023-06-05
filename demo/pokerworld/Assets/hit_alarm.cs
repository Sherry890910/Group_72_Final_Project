using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_alarm : MonoBehaviour
{
    public Animator alarm;
   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "hit_alarm")
        {
            Debug.Log("Yes");
            alarm.SetBool("is_moving", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
